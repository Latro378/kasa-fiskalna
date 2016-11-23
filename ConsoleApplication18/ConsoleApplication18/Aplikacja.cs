using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication18
{
    class Aplikacja : Koszyk
    {
        public char klawisz;
        public double iloczyn=0, suma=0;
        public void WypiszLegende()
        {
            Console.WriteLine("Dzień Dobry!\nCo Chcesz zrobić? Naciśnij odpowiedni klawisz.");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartość koszyka");
            Console.WriteLine("2S - pokaz Sumę do zapłaty");
            Console.WriteLine("X - skasuj produkt z listy (musisz znać wcześniej numer na liście");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - Zakończ program");
        }
        public void WczytajKlawisz()
        {
            while (klawisz != 'E')
            {
                WypiszLegende();
                klawisz = Console.ReadKey().KeyChar;
                WykonajDzialanie();
            }
        }
        public void WykonajDzialanie()
        {

            switch (klawisz)
            {
                case 'P':
                    PobierzProdukt();
                    zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
                    Console.WriteLine("Dodano: {0} Cena: {1}\n", nazwa, cenaJednostkowa);
                    break;
                case 'K':

                    break;
                case 'Z':
                    foreach (var z in zakupy)
                    {
                        Console.WriteLine("\nNazwa: {0}\nCena: {1}\nIlsoc: {2}", z.nazwa, z.cenaJednostkowa, z.ilosc);
                    }

                    break;
                case 'S':
                    foreach(var z in zakupy)
                    {
                        iloczyn =Convert.ToDouble(z.ilosc) * z.cenaJednostkowa;
                        suma = suma + iloczyn;
                    }
                    Console.WriteLine("Suma: {0}",suma);
                    break;
                case 'X':

                    break;
                case 'W':

                    break;
                case 'N':

                    break;
            }
        }

        
    }
}

