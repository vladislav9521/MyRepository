﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder mazdaWorker = new MazdaBuilder();
            new CarConstructor(mazdaWorker).Construct();
 
            Console.WriteLine(mazdaWorker.Car);

            Console.Read();
        }
    }
}
