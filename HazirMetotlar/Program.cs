using System;

namespace HazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***** String *****");
            //string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            //string degisken2 = "CSharp";

            //// Length
            //Console.WriteLine(degisken.Length);

            ////ToUpper , ToLower
            //Console.WriteLine(degisken.ToUpper());
            //Console.WriteLine(degisken.ToLower());


            ////Concat
            //Console.WriteLine(string.Concat(degisken,"Merhaba"));

            ////Compare , CompareTo
            //Console.WriteLine(degisken.CompareTo(degisken2));  //0,1,-1
            //Console.WriteLine(string.Compare(degisken,degisken2,true));
            //Console.WriteLine(string.Compare(degisken, degisken2, false));

            ////Contains
            //Console.WriteLine(degisken.Contains(degisken2));
            //Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            //Console.WriteLine(degisken.StartsWith("Merhaba!"));

            ////IndexOf
            //Console.WriteLine(degisken.IndexOf("CS"));
            //Console.WriteLine(degisken.IndexOf("Tugba"));
            //Console.WriteLine(degisken.LastIndexOf("i"));

            ////Insert
            //Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            ////padLeft, PadRight
            //Console.WriteLine(degisken + degisken2.PadLeft(30));
            //Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            //Console.WriteLine(degisken.PadRight(50)+degisken2);
            //Console.WriteLine(degisken.PadRight(50,'-')+degisken2);


            ////Remove
            //Console.WriteLine(degisken.Remove(10));
            //Console.WriteLine(degisken.Remove(5,3));
            //Console.WriteLine(degisken.Remove(0,1));

            ////Replace
            //Console.WriteLine(degisken.Replace("CSharp","C#"));
            //Console.WriteLine(degisken.Replace(" ","*"));

            ////Split
            //Console.WriteLine(degisken.Split(' ')[1]);

            ////Substring
            //Console.WriteLine(degisken.Substring(4));
            //Console.WriteLine(degisken.Substring(4,6));



            Console.WriteLine("***** DateTime *****");

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);


            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));



            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));


            //Math
            Console.WriteLine("***** Math *****");

            Console.WriteLine(Math.Abs(-21)); //mutlak değer
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));

            Console.WriteLine(Math.Ceiling(22.3)); //23 verilenden büyük tamsayı
            Console.WriteLine(Math.Round(22.3));  // 22 yuvarlama
            Console.WriteLine(Math.Round(22.7)); //23
            Console.WriteLine(Math.Floor(22.7));  //22 aşağı yuvarlama


            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));


            Console.WriteLine(Math.Pow(3,4)); //üs alma 3 üzeeri 4
            Console.WriteLine(Math.Sqrt(9)); //karekök
            Console.WriteLine(Math.Log(9));// 9 un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); //e üzeri 3
            Console.WriteLine(Math.Log10(100)); //log 10 tabanında 100


        }
    }
}
