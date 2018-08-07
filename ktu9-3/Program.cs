using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktu9_3
{
    class Program
    {   
        private void Tikrinti(ref int duomKiekis, ref int[] duom, ref int check, ref int tikr)
        {
            if(duom.Sum() % 2 == check)
            {
                tikr = 1;
            }
        }
        static void Main(string[] args)
        {
            string eilute = System.IO.File.ReadAllText(@"C:\Users\Andrius\Documents\Visual Studio 2017\ktu\ktu9-3\ktu9-3\duomenys.txt");
            string[] eile = eilute.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            int duomenuKiekis = Convert.ToInt32(eile[0]);
            int[] duomenys = new int[duomenuKiekis];
            int check = Convert.ToInt32(eile[eile.Length - 1]);
            for (int i = 0; i < duomenuKiekis; i++)
            {
                int duom = Convert.ToInt32(eile[i + 1]);
                duomenys[i] = duom;
            }

            int tikr = 0;
            Program prog = new Program();
            prog.Tikrinti(ref duomenuKiekis, ref duomenys, ref check, ref tikr);

            prog.spausdinti(tikr);
        }

        private void spausdinti(int tikr)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\Users\Andrius\Documents\Visual Studio 2017\ktu\ktu9-3\ktu9-3\rezultatai.txt"))
            {
                if (tikr == 0)
                {
                    file.WriteLine("Duomenų atsiųsti be klaidų nepavyko, reikia pakartoti siuntimą");
                }
                else if (tikr == 1)
                {
                    file.WriteLine("Duomenys atsiųsti sėkmingai");
                }
            }
        }
    }
}
