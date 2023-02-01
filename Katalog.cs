using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ksiegarnia
{
    internal class Katalog
    {
        List<Ksiazka> ksiazki;

        public Katalog()
        {
            ksiazki = new List<Ksiazka>();
        }

        public void Dodaj()
        {
            Ksiazka ksi = new Ksiazka();
            ksi.Czytaj();
            ksiazki.Add(ksi);
        }

        public void Wyswietl()
        {
            Console.WriteLine("Ksiazki w ofercie:");
            Console.WriteLine("---------");
            foreach (Ksiazka ksi in ksiazki)
            {
                ksi.Wyswietl();
                Console.WriteLine("----------------------");
            }
        }
        
        
    }
}
