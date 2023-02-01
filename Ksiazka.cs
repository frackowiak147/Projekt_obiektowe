using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ksiegarnia
{

    internal class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string Kategoria { get; set; }
        public int Ilosc { get; set; }
        public int Cena { get; set; }

        public void Czytaj()
        {
            Console.Write("Tytuł = ");
            Tytul = Console.ReadLine();
            Console.Write("Autor = ");
            Autor = Console.ReadLine();

            Menu.kategorie();
            
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {

                case 1: Console.WriteLine("1. Naukowe"); Kategoria = "Naukowe"; break;
                case 2: Console.WriteLine("2. Fantastyka"); Kategoria = "Fantastyka";  break;
                case 3: Console.WriteLine("3. Kryminały"); Kategoria = "Kryminały";  break;
                case 4: Console.WriteLine("4. Inne"); Kategoria = "Inne";  break;
                default: Console.WriteLine("4. Inne"); Kategoria = "Inne";  break;
            }

            Console.Write("Ilosc = ");
            Ilosc = int.Parse(Console.ReadLine());
            Console.Write("Cena = ");
            Cena = int.Parse(Console.ReadLine());
        }
        
        public void Wyswietl()
        {
            Console.WriteLine($"Tytuł: {Tytul}");
            Console.WriteLine($"Autor = {Autor}");
            Console.WriteLine($"Kategoria = {Kategoria}");
            Console.WriteLine($"Ilosc = {Ilosc}");
            Console.WriteLine($"Cena: {Cena} zł");
        }

    }

    }
