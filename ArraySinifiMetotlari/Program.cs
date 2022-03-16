using System;

namespace ArraySinifiMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("***** Sırasız Liste *****");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            Console.WriteLine("***** Sıralı Liste *****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            string[] kelimeler = { "kuş", "köpek", "balık", "at", "eşek" };
            Array.Sort(kelimeler);
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            //Clear
            Console.WriteLine("***** Array Clear *****");
            Array.Clear(sayiDizisi, 2, 2); //2. indexten itibaren 2 elemanı sıfırlar
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            //Reverse
            Console.WriteLine("***** Reverse *****");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("***** IndexOf *****");
            
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));
            //Resize
            Console.WriteLine("***** Resize *****");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
