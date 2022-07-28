using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace AbstractSiniflar
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur() { return 4; }
        public virtual Renk StandartRenk() { return Renk.Beyaz; }
        public abstract Marka HangiMarkaninAraci();
    }
}
