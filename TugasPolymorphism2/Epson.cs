﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism2
{
    class Epson : IPrinterWindows
    {
        public void Print()
        {
            Console.WriteLine("Epson printer is printing.....");
        }

        public void Show()
        {
            Console.WriteLine("Epson display dimension : 10*11");
        }
    }
}
