using System;

namespace adsoyad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz");
            string isim = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Merhaba " + isim + " " + soyisim);
        }
    }
}


