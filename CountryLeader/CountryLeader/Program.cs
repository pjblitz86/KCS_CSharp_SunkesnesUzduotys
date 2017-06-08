using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryLeader
{
    class Program
    {
        // unikaliausias vardas ir daugiausiai skirtingu raidziu prezidentas
        // iveda vardus kandidatu ir kuris bus prezidentas su unikaliu daugiausia

        // PAIESKA MASYVE

        public int unikalius_elementus(char[] elementai)
        {
            int kiekis_unikaliu = 0;
            for (int i = 0; i < elementai.Length; i++)
            {
                int neunikalu = 0;
                for (int j = i + 1; j < elementai.Length; j++)
                {
                    if (elementai[i] == elementai[j])
                    {
                        neunikalu++;
                    }
                }
                if (neunikalu == 0)
                {
                    kiekis_unikaliu++;
                }
            }

            return kiekis_unikaliu;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite visus kandidatus:");
            string Vardai = Console.ReadLine();
            string[] Kandidatai = Vardai.Split(' ').ToArray();
            int Max_Value = int.MinValue;
            int Max_Value_index = -1;
            for(int i=0; i < Kandidatai.Length; i++)
            {
                char[] Raides = Kandidatai[i].ToCharArray();
                Program Lyderis = new Program();
                if (Max_Value < Lyderis.unikalius_elementus(Raides))
                {
                    Max_Value = Lyderis.unikalius_elementus(Raides);
                    Max_Value_index = i;
                }
            }
            Console.WriteLine("Lyderis yra: " + Kandidatai[Max_Value_index]);

            Console.ReadKey();
        }
    }
}
