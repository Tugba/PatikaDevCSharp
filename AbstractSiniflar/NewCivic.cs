using InterfaceOrnek;
using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace AbstractSiniflar
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Honda;
        }        public override Renk StandartRenk()
        {
            return Renk.Gri;
        }    }
}
