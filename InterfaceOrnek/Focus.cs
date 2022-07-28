using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace InterfaceOrnek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
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
