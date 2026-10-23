using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterApp
{
    internal class ColorPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            base.Print(value);
            Console.ResetColor();
        }
    }
}
