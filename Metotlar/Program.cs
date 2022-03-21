 using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim belirteci,geri dönüş tipi,metot adı(parametre listesi/argüman)
            /*
            {
            komutlar;
            return
            }
            */

            int a = 2;
            int b = 3;
           int sonuc= Topla(a,b);
            
            Console.WriteLine(a+b);
            Console.WriteLine(sonuc);

            Metotlar metotlar = new Metotlar();
            metotlar.EkranaYazdir(Convert.ToString( sonuc));
            Console.WriteLine("***");
            int sonuc2 = metotlar.ArttirVeTopla(ref a,ref  b);
            metotlar.EkranaYazdir(Convert.ToString( sonuc2));
            Console.ReadLine();


        }
       public static int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }

    }
    class Metotlar
    {
      public void  EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
