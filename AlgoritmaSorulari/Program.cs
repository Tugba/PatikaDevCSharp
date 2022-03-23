using System;

namespace AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            //Console.Write("Bir sayi giriniz: ");
            //int sayi =Convert.ToInt32( Console.ReadLine());
            //int[] sayilar = new int[sayi];
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.Write("{0}. sayıyı girin: ", i+1);
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    int kalan = sayilar[i] % 2;
            //    if (kalan==0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }
            // }


            // 2) Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            //Console.WriteLine("İki sayı giriniz: ");
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());


            //int[] sayilar = new int[n];
            //for (int i = 0; i < n; i++)
            //{

            //    Console.Write("{0}. sayıyı girin: ", i + 1);
            //    sayilar[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i<sayilar.Length; i++)
            //{
            //    if ((sayilar[i] == m) || (sayilar[i] % m) == 0)
            //    {
            //        Console.WriteLine(sayilar[i]);
            //    }

            //}


            // 3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            //Console.WriteLine("Sayi giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //string[] kelimeler = new string[sayi];
            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine("{0}. kelimeyi giriniz: ",i+1);
            //    kelimeler[i] = Convert.ToString(Console.ReadLine());

            //}
            //Console.WriteLine("***************");
            //foreach (var kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}
            //Console.WriteLine("***************");
            //Array.Reverse(kelimeler);
            //foreach (var kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}


            
            // 4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Bir cümle giriniz : ");
            string cumle = Convert.ToString(Console.ReadLine());
            string[] kelimeler = cumle.Split(" ");
            char[] harf = cumle.ToCharArray();

            Console.WriteLine("Kelime Sayısı: {0}", kelimeler.Length);
            Console.WriteLine("Harf Sayısı : {0}",harf.Length);

        }


    }
}

