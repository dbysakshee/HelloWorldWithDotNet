﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWithDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();

            Console.WriteLine(d.ShowMessage());
            Console.ReadKey();
        }
    }
}
