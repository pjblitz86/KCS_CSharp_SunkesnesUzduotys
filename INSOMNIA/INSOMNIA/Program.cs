using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSOMNIA
{
    class Program
    {
        public int[] masyvas = new int[10];
        int suma = 0;
        public bool ArJau10()
        {
            int suma = 0;
            for (int i = 0; i < masyvas.Length; i++)
            {
                suma += masyvas[i];
            }
            if (suma == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Pagrindine(int skaiciuss)
        {
            Tikrinas(skaiciuss);
            int daugiklis = 1;
            while(!ArJau10())
            {
                int tarpinis = skaiciuss * daugiklis;
                daugiklis++;
                Tikrinas(tarpinis);
                if(ArJau10())
                {
                    skaiciuss = tarpinis;
                }
            }
            Console.WriteLine("Skaiciu kiekis {0}\nPaskutinis skaicius {1}", daugiklis, skaiciuss);
                
        }
        public void Tikrinas (int sk)
        {
            while (sk > 0)
        {
                int liekana = sk % 10;
                Patikrinimas10(liekana);
                sk /= 10;
        }
        }
        
           
        public void Patikrinimas10 (int skaicius)
        {
            switch (skaicius)
            {
                case 0:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 1:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 2:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 3:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 4:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 5:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 6:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 7:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 8:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
                case 9:
                    if (masyvas[skaicius] == 0)
                    {
                        masyvas[skaicius] = 1;
                    }
                    break;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("BEATRICES INSOMNIA");
            
            Console.WriteLine("Iveskite skaiciu:");
            int sugalvotasSkaicius = Convert.ToInt32(Console.ReadLine());
            if(sugalvotasSkaicius == 0)
            {
                Console.WriteLine("INSOMNIA");
            }
            else
            {
                // sudetingiausia vieta
                Program programa = new Program();
                programa.Pagrindine(sugalvotasSkaicius);
            }

            Console.ReadKey();
        }
    }
}
