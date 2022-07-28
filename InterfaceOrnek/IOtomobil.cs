using System;
using System.Collections.Generic;
using System.Text;
using static InterfaceOrnek.Sabitler;

namespace InterfaceOrnek
{
   public interface IOtomobil
    {
        int KacTekerlektenOlusur();
        Marka HangiMarkaninAraci();
        Renk StandartRenk();
    }
}
