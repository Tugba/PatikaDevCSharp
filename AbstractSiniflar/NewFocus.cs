using InterfaceOrnek;
using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace AbstractSiniflar
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}
