﻿using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
           
            tohumluBitki.TohumlaCogalma();
            

            Console.WriteLine("**********************");

            Kuslar martı = new Kuslar();
          
            martı.Ucmak();
            
           
        }
    }
}
