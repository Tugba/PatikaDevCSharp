using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine("d: "+d);

            long h = d;
            Console.WriteLine("h:"+h);
            float i = h;
            Console.WriteLine("i: "+i);
            string s = "tugba";
            char f = 'c';
            object g = s + f + d;
            Console.WriteLine("g:"+g);

            //Explicit Conversion(Bilinçli Dönüşüm)
            Console.WriteLine("************");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: "+y);
            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: "+t);
            float w= 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: "+v);

            //****ToString******
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: "+yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: "+zz);

            //****System.Convert****
            string s1 = "10", s2 = "20";
            int sayi1, sayi2,Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+Toplam);

            //****Parse****
            //Parse string ifadelere dönüştürmek için kullanılır
            string metin1 = "10";
            string metin2 = "10.25";
            int sayi3;
            double sayi4;

            sayi3 = Int32.Parse(metin1);
            sayi4 = double.Parse(metin2);
            Console.WriteLine("sayi3:"+sayi3);
            Console.WriteLine("sayi4: "+sayi4);

            

            Console.ReadKey();
        }
    }
}
