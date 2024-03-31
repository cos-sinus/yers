using System;

namespace HW3_3
{
    class Program
    {
        static void Main()
        {
            OneDimenshionalArr<int> intArr = new();
            OneDimenshionalArr<double> doubleArr = new();

            intArr.AddElem(10);
            intArr.AddElem(20);
            intArr.AddElem(30);
            intArr.AddElem(40);
            intArr.AddElem(50);
            intArr.Print();
            doubleArr.AddElem(2.3);
            doubleArr.AddElem(3.3);
            doubleArr.AddElem(4.3);
            doubleArr.AddElem(5.3);
            doubleArr.AddElem(6.3);
            doubleArr.Print();

            intArr.DelElem(4);
            intArr.Print();
            doubleArr.DelElem(2);
            doubleArr.Print();

            intArr.SortArr();
            intArr.Print();
            doubleArr.SortArr();
            doubleArr.Print();

            intArr.CountElem();
            intArr.Print();
            doubleArr.CountElem();
            doubleArr.Print();

            Console.WriteLine(intArr.CountSomeElem(x => Math.Abs(x) < 100));
            Console.WriteLine(doubleArr.CountSomeElem(x => Math.Abs(x) < 100));

            Console.WriteLine(intArr.IfElem(x => Math.Abs(x) < 100));
            Console.WriteLine(doubleArr.IfElem(x => Math.Abs(x) < 100));

            Console.WriteLine(intArr.IfAllElems(x => Math.Abs(x) < 100));
            Console.WriteLine(doubleArr.IfAllElems(x => Math.Abs(x) < 100));

            Console.WriteLine(intArr.IsElem(int.Parse(Console.ReadLine())));
            Console.WriteLine(doubleArr.IsElem(double.Parse(Console.ReadLine())));

            intArr.FirstIfElem((x) => Math.Abs(x) < 100);
            doubleArr.FirstIfElem(x => Math.Abs(x) < 100);

            int a = int.Parse(Console.ReadLine());
            intArr.ActionOnArr((x) => x * 2);
            doubleArr.ActionOnArr((x) => x * 2);

            intArr.ElemsActionOnArr(x => x % 2 == 0);
            doubleArr.ElemsActionOnArr(x => x % 2 == 0);

            intArr.Rra();
            intArr.Print();
            doubleArr.Rra();
            doubleArr.Print();

            intArr.MinMaxElem();
            intArr.Print();
            doubleArr.MinMaxElem();
            doubleArr.Print();

            intArr.MinMaxElemByProection((x) => x * x);
            doubleArr.MinMaxElemByProection((x) => x * x);

            intArr.ProjElemToNewType((x) => x.ToString());
            intArr.Print();
            doubleArr.ProjElemToNewType((x) => x.ToString());
            doubleArr.Print();

            intArr.GiveDiaposoneElems(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            doubleArr.GiveDiaposoneElems(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            intArr.Iteration();
            doubleArr.Iteration();
        }
    }
}