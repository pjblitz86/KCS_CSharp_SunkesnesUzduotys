using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;


namespace Kamera
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        public bool filter = false;
        public AForge.Imaging.Filters.Invert inverteris = new AForge.Imaging.Filters.Invert();
        public VideoCaptureDevice videoSource;
        public Bitmap bitmap = null;
        public Form1()
        {
            InitializeComponent();
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if(videoDevices.Count == 0)
                {
                    throw new ApplicationException();
                }
                foreach (FilterInfo device in videoDevices)
                {
                    comboBox1.Items.Add(device.Name);
                }
            }
            catch (ApplicationException)
            {
                comboBox1.Items.Add("Nera lokaliu video irenginiu");
                videoDevices = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs) // kas atsiunte, del ko ivyko
        {
            bitmap = (Bitmap)eventArgs.Frame.Clone();
            this.Invoke((MethodInvoker)delegate
            {
                if(filter)
                {
                    bitmap = Update_frame_color(bitmap);
                }
                pictureBox1.Image = bitmap;
                pictureBox1.Refresh();
            });
        }
        public Bitmap Update_frame_color(Bitmap bitimap)
        {
            inverteris.ApplyInPlace(bitimap);
            return bitimap;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(filter)
            {
                filter = false;
            }
            else
            {
                filter = true;
            }
            
        }

    }
}
