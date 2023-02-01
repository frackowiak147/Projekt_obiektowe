using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ksiegarnia
{
    internal class Program
    {
       
        public static void Main(string[] args)
         {

            Katalog k = new Katalog();
            Zapis_odczyt z = new Zapis_odczyt();

            void Dodaj()
            {
                k.Dodaj();
            }
            void Wyswietl()
            {
                k.Wyswietl();
            }
            void wyswietlanie_pliku()
            {
                z.wyswietlanie_pliku();
            }

            bool koniec = false;

                while (!koniec)
                {
                
                Menu.choices();
                    
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        
                        case 1: Console.WriteLine("1. Wyswietl"); Wyswietl(); Menu.any_key();break;
                        case 2: Console.WriteLine("2.  Dodaj"); Dodaj(); Menu.any_key(); break;
                        case 3: Console.WriteLine("3. Spis kategorii"); Menu.kategorie();  Menu.any_key(); break;
                        case 4: Console.WriteLine("4. Wyswietl plik tekstowy"); wyswietlanie_pliku(); Menu.any_key(); break;
                        case 5: Console.WriteLine("5. Inne"); Menu.any_key(); break;

                        case 0: koniec = true; break;
                    }

                }
            
        }

     


    }
}
