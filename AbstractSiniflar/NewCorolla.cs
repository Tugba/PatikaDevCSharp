using InterfaceOrnek;
using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace AbstractSiniflar
{
    public class NewCorolla : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Toyota;
        }
    }
}
