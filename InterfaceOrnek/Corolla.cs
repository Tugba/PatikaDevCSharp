using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace InterfaceOrnek
{
    public class Corolla : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRenk()
        {
            return Renk.Beyaz;
        }
    }
}
