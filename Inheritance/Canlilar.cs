﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
  public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }
        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}
