using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HW3_3.OneDimenshionArray;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW3_3
{
    class Program
    {
        static void Main()
        {
            BaseArray[] array = new BaseArray[3]
            {
            new OneDemensionArray(3),
            new TwoDemenshionArray(2, 3),
            new JaggedArray(3)
            };

            foreach (var a in array)
            {
                a.Print();
                a.AverageValue();
            }

            IPrinter[] print = new IPrinter[4];

            print[0] = array[0];
            print[1] = array[1];
            print[2] = array[2];
            print[3] = new Printer();

            foreach (var item in print)
            {
                item.Print();
            }
        }
    }
}
