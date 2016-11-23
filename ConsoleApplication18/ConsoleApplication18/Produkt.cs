using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Produkt
    {
        public string nazwa;
        public double cenaJednostkowa;
        public int ilosc;
       
        public Produkt()
        {
            this.nazwa = "brak";
            this.cenaJednostkowa = 0;
            this.ilosc = 0;
        }
        public Produkt(string nazwa, double cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }
            public void PobierzProdukt()
        {
            Console.WriteLine("\nPodaj nazwe produktu: ");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj cene za jednostke: ");
            cenaJednostkowa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj ilosc: ");
            ilosc = Convert.ToInt32(Console.ReadLine());
        }
    }
}
