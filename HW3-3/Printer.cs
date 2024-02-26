using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW3_3
{
    internal class Printer : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday");
        }
    }
}
