using System;

namespace WhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den başlayarak consoledan girilen sayıya kadar(sayı dahil) ortalama hesaplayıp ekrana yazdıran program
            Console.Write("Sayı giriniz: ");
            int sayi= int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine("Ortalama: "+toplam / sayi);


            //a dan zye kadar tüm harfleri ekrana yazdıralım
            char karakter = 'a';
            while (karakter<='z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }

            //foreach
            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
            Console.ReadKey();

        }
    }
}
