using System;

namespace StructKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}",dikdortgen.AlanHesapla());

            DikdortgenStruct dikdortgenStruct=new DikdortgenStruct(3,4);
            Console.WriteLine("Class Alan Hesabı: {0}", dikdortgenStruct.AlanHesapla());

        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct DikdortgenStruct
    {
        public int KisaKenar;
        public int UzunKenar;
        public DikdortgenStruct(int kisaKenar, int uzunKenar)
        {

           
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
    
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
