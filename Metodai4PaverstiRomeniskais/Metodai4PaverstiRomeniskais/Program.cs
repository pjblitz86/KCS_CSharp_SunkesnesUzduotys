using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodai4PaverstiRomeniskais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arabisku skaiciu pavertimas romeniskais");
            Console.WriteLine();
            Program romenas = new Program();

            romenas.paklausimas("Iveskite naturalu skaiciu iki 999 imtinai");
            int sk = Convert.ToInt32(Console.ReadLine());
            int sk1 = sk % 10;
            int sk2 = (sk % 100) / 10;
            int sk3 = sk / 100;
            string vienzenklis = null;
            string dvizenklis = null;
            string trizenklis = null;

            romenas.Vienzenklis(sk1, dvizenklis, trizenklis, out vienzenklis);
            romenas.Dvizenkliai(sk2, out dvizenklis);
            romenas.Trizenkliai(sk3, out trizenklis);
            
            romenas.paklausimas(trizenklis + dvizenklis + vienzenklis);
            Console.ReadKey();

        }
        /// <summary>
        /// Funkcija kuri uzduoda klausima arba grazina skaiciu
        /// </summary>
        /// <param name="klausimas"></param>
        private void paklausimas(string klausimas)

        {
            Console.WriteLine(klausimas);
        }
        /// <summary>
        /// Randa romeniska skaiciu nuo 0 iki 9
        /// </summary>
        /// <param name="skaicius"></param>
        /// <param name="atsakymas"></param>
        private void Vienzenklis(int skaicius, string dvizenklis, string trizenklis, out string atsakymas)
        {
            atsakymas = null;
            if (skaicius == 0 && dvizenklis == null && trizenklis == null)
            {
                atsakymas = "0";
            }
            if (skaicius == 0)
            {
                atsakymas = "0";
            }
            else if (skaicius == 9)
            {
                atsakymas = "IX";
            }
            else if (skaicius == 4)
            {
                atsakymas = "IV";
            }
            else
            {
                int k = skaicius / 5;
                int l = skaicius % 5;
                if (k == 1)
                {
                    atsakymas = "V";
                }

                while (l > 0)
                {
                    atsakymas += "I";
                    l--;
                }
            }
        }
        /// <summary>
        /// Funkcija kuri grazina dvizenkli skaiciu
        /// </summary>
        /// <param name="skaicius"></param>
        /// <param name="atsakymas"></param>
        private void Dvizenkliai(int skaicius, out string atsakymas)
        {
            atsakymas = null;
            if (skaicius == 0)
            {
                ;
            }
            else if (skaicius == 4)
            {
                atsakymas = "XL";
            }
            else if (skaicius == 9)
            {
                atsakymas = "XC";
            }
            else
            {
                int k = skaicius / 5;
                int l = skaicius % 5;
                if (k == 1)
                {
                    atsakymas = "L";
                }

                while (l > 0)
                {
                    atsakymas += "X";
                    l--;
                }
            }
        }
        private void Trizenkliai (int skaicius, out string atsakymas)
        {
            atsakymas = null;
            if (skaicius == 0)
            {
                ;
            }
            else if (skaicius == 4)
            {
                atsakymas = "CD";
            }
            else if (skaicius == 9)
            {
                atsakymas = "CM";
            }
            else
            {
                int k = skaicius / 5;
                int l = skaicius % 5;
                if (k == 1)
                {
                    atsakymas = "D";
                }

                while (l > 0)
                {
                    atsakymas += "C";
                    l--;
                }
            }
        }
    }
}



