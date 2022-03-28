using System;
using System.Collections;

namespace KoleksiyonlarOdev

{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Soru - 1)");
            ////Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

            ////            Negatif ve numeric olmayan girişleri engelleyin.
            ////Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            ////Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
            //int asalToplam = 0;
            //double asalOrtalama = 0.00;
            //double asalOlmayanOrtalama = 0.00;
            //int asalOlmayanToplam = 0;
            //ArrayList asalSayilar = new ArrayList();
            //ArrayList asalOlmayanSayilar = new ArrayList();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}. sayı:",i+1);
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    if (AsalMi(s))
            //    {
            //        asalSayilar.Add(s);
            //        asalToplam += s;
            //    }
            //    else
            //    {
            //        asalOlmayanSayilar.Add(s);
            //        asalOlmayanToplam += s;
            //    }


            //}

            //asalSayilar.Sort();
            //asalSayilar.Reverse();

            //Console.WriteLine("Asal Sayılar: ");

            //foreach (var item in asalSayilar)
            //{
            //    Console.Write(item+"  ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Asal sayı adedi: "+asalSayilar.Count);

            //asalOrtalama =Convert.ToDouble( asalToplam )/Convert.ToDouble( asalSayilar.Count);

            //Console.WriteLine("Asal Sayıların Ortalaması: "+asalOrtalama);

            //asalOlmayanSayilar.Sort();
            //asalOlmayanSayilar.Reverse();

            //Console.WriteLine();
            //Console.WriteLine("Asal Olmayan Sayılar: ");

            //foreach (var item in asalOlmayanSayilar)
            //{
            //    Console.Write(item+"  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Asal olmayan sayı adedi: " + asalOlmayanSayilar.Count);

            //asalOlmayanOrtalama = Convert.ToDouble(asalOlmayanToplam) / Convert.ToDouble(asalOlmayanSayilar.Count);

            //Console.WriteLine("Asal Sayıların Ortalaması: " + asalOlmayanOrtalama);

            // Console.WriteLine("Soru - 2 )");
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            //ArrayList sayiDizisi = new ArrayList();

            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("{0}.sayi :", i + 1);
            //    int sayi = int.Parse(Console.ReadLine());
            //    sayiDizisi.Add(sayi);
            //}

            //sayiDizisi.Sort();
            //Console.WriteLine("Sayılar: ");

            //foreach (var item in sayiDizisi)
            //{
            //    Console.Write(item + " ");
            //}

            //int minToplam=0;
            //for (int i = 0; i < 3; i++)
            //{
            //    minToplam += Convert.ToInt32(sayiDizisi[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Min toplam: "+minToplam);
            //double minOrtalama =Convert.ToDouble(minToplam)/ 3;
            //Console.WriteLine("Min ortalama: "+ minOrtalama);


            //int maxToplam = 0;
            //for (int i = 17; i <20; i++)
            //{
            //    maxToplam += Convert.ToInt32(sayiDizisi[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Max toplam: "+maxToplam);
            //double maxOrtalama = Convert.ToDouble(maxToplam) / 3;
            //Console.WriteLine("Max ortalama: " + maxOrtalama);




            Console.WriteLine("Soru - 3) ");
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            string cumle = Console.ReadLine().ToLower();

            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            ArrayList yenisesli = new ArrayList();
            foreach (char  karakter in cumle)
            {
                foreach (var sesli in sesliler)
                {
                    if (karakter==sesli)
                    {
                        yenisesli.Add(karakter);
                    }

                }
            }
            yenisesli.Sort();
            Console.WriteLine("Yeni dizi:" );
            foreach (var item in yenisesli)
            {
                Console.Write(item+" ");
            }

        }
           
            
           
            


        }


    }
    //public static bool AsalMi(int sayi)
    //{
    //    bool durum = false;
    //    int kontrol = 0;

    //    for (int i = 2; i < sayi; i++)
    //    {
    //        if (sayi % i == 0)
    //        {
    //            kontrol = 1;
    //            break;
    //        }
    //    }
    //    if (sayi==1)
    //    {
    //        durum = false;
    //    }
    //    else if (kontrol==1 )
    //    {
    //        durum = false;
    //    }
    //    else
    //    {
    //        durum = true;
    //    }
    //    return durum;
    //}


