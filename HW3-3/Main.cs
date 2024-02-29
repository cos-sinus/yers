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
            Console.WriteLine("False - рандомное заполнение, true - заполнение с клавиатуры");

            bool choice = bool.Parse(Console.ReadLine());

            BaseArray[] array =
            {
            new OneDimenshionArray(choice),
            new TwoDemenshionArray(choice),
            new JaggedArray(choice)
            };

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine("Massive " + i.ToString() + ":");
                array[i - 1].Print();
                array[i - 1].AverageValue();

                Console.WriteLine("Massive " + i.ToString() + ".1:");
                array[i - 1].ReCreate(choice);
                array[i - 1].Print();
                array[i - 1].AverageValue();
            }

            IPrinter[] print =
            {
            array[0],
            array[1],
            array[2],
            new Printer(),
            };

            foreach (var item in print)
            {
                item.Print();
            }
        }
    }
}
