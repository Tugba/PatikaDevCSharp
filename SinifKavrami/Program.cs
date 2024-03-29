﻿using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();

            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 25415634;
            calisan1.Departman = "İnsan Kaynakları";
            
            calisan1.CalisanBilgileri();

            Console.WriteLine("******************** ");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25645789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();




        }
    }


    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int No { get; set; }
        public string Departman { get; set; }


        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Departmanı : {0}", Departman);
        }
    }
}
