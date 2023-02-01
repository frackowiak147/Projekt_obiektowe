using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ksiegarnia
{
    internal class Zapis_odczyt
    {
        public void wyswietlanie_pliku()
        {
            if (File.Exists("ksiegarnia_dane.txt"))
            {
                string myString = File.ReadAllText("ksiegarnia_dane.txt");
                Console.WriteLine(myString);
            }

            if (File.Exists("ksiegarnia_dane.txt"))
            {
               
                string nemyString = "xxx2";
                File.WriteAllText("ksiegarnia_dane.txt", nemyString);
            }

        }
    }
}
