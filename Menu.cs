using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ksiegarnia
{
    internal class Menu
    {
        public static void hello()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Witaj w programie ksiegarnia--------------------");
            Console.WriteLine("---------------Zapoznaj sie z nasza oferta...-------------------");
            Console.WriteLine();
            


        }
        public static void choices()
        {
            Console.Clear();
            hello();
            Console.WriteLine("1. Wyswietl ksiazki w ofercie");
            Console.WriteLine("2. Dodaj");
            Console.WriteLine("3. Spis kategorii");
            Console.WriteLine("4. Wyswietl plik tekstowy");
            Console.WriteLine("5. ----");
            Console.WriteLine("0. Zamknij program");
            Console.WriteLine();
            Console.Write("?> ");
            Console.WriteLine();
        }

        public static void any_key()
        {
            Console.WriteLine("Nacisnij ENTER aby kontynuować: ");
            string user_key = Console.ReadLine();
        }
        public static void kategorie()
        {
            Console.WriteLine("Kategoria: ");
            Console.WriteLine("1. Naukowe");
            Console.WriteLine("2. Fantastyka");
            Console.WriteLine("3. Kryminały");
            Console.WriteLine("4. Inne");
        }
        



    }
}
