using System;

namespace HW3_4
{
    abstract class BaseArray<T> : IBaseArray, IPrinter
    {
        public virtual void ReCreate()
        {
            Console.WriteLine("False - рандомное заполнение, true - заполнение с клавиатуры");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                ArrayByUser();
            }
            else
            {
                RandomArray();
            }
        }

        public abstract void ArrayByUser();

        public abstract void RandomArray();

        public abstract void Print();
    }
}
