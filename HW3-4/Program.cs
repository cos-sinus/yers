using HW3_4;
using System;

namespace HW3_3
{
    class Program
    {
        static void Main()
        {
            IValueProvider<int> pint = new ProvValInt();
            IValueProvider<double> pdoub = new ProvValDoub();
            IValueProvider<bool> pbool = new ProvValBool();
            IValueProvider<string> pstr = new ProvValStr();

            OneDimenshionArray<int> intOneDimenshionArray = new OneDimenshionArray<int>(pint);
            OneDimenshionArray<double> doubleOneDimenshionArray = new OneDimenshionArray<double>(pdoub);
            OneDimenshionArray<bool> boolOneDimenshionArray = new OneDimenshionArray<bool>(pbool);
            OneDimenshionArray<string> stringOneDimenshionArray = new OneDimenshionArray<string>(pstr);

            TwoDemenshionArray<int> intTwoDemenshionArray = new TwoDemenshionArray<int>(pint);
            TwoDemenshionArray<double> doubleTwoDemenshionArray = new TwoDemenshionArray<double>(pdoub);
            TwoDemenshionArray<bool> boolTwoDemenshionArray = new TwoDemenshionArray<bool>(pbool);
            TwoDemenshionArray<string> stringTwoDemenshionArray = new TwoDemenshionArray<string>(pstr);

            

            IPrinter[] printers = new IPrinter[]
            {
                intOneDimenshionArray,
                doubleOneDimenshionArray,
                boolOneDimenshionArray,
                stringOneDimenshionArray,
                intTwoDemenshionArray,
                doubleTwoDemenshionArray,
                boolTwoDemenshionArray,
                stringTwoDemenshionArray
            };

            foreach (IPrinter printer in printers)
            {
                Console.WriteLine($"Элементы массива {printer.GetType()}:");
                printer.Print();
            }
        }
    }
}