using System;

namespace RekürsifVeExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif-Özyinelemeli metotlar
            //3^4 hesaplama
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;

            }
            Console.WriteLine(result);
            Islemler islemler = new Islemler();

            Console.WriteLine(islemler.Expo(3,4));


            //Extension Metotlar
            string ifade = "adsgf jhjlkj kjlkj";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSapaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());
            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
           
            Console.WriteLine(sayi.IsEvenNumbet());
            Console.WriteLine(ifade.getFirstCharacter());
        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)
        {
            if (us<2)
            {
                return sayi;
            }
            return Expo(sayi, us - 1) * sayi;
        }
    }
    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
            {
            return param.Contains(" ");
            }
        public static string RemoveWhiteSapaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumbet(this int param)
        {
            return param % 2 == 0;
        }

        public static string getFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
    
}