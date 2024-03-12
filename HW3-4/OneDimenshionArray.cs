using System;
namespace HW3_4
{

    internal class OneDimenshionArray<T> : BaseArray<T>
    {
        private Random random;
        private IValueProvider<T> _provider;
        private T[] array;

        public OneDimenshionArray(IValueProvider<T> provider)
        {
            _provider = provider;
            ReCreate();
        }

        public override void ArrayByUser()
        {
            Console.WriteLine("Введите длинну массива");
            array = new T[int.Parse(Console.ReadLine())];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < array.Length; i++)
            {
                string vvod = Console.ReadLine();
                if (vvod.Contains(","))
                {
                    double[] doubleValue = new double[vvod.Split(',').Length];
                    array[i] = (T)(object)doubleValue;
                }
                else if (double.TryParse(vvod, out double value))
                {
                    array[i] = _provider.GetUserValue();
                }
            }
        }

        public override void RandomArray()
        {
            Console.WriteLine("Введите длинну массива:");
            array = new T[int.Parse(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = _provider.GetRandomValue();
            }
        }

        public override void Print()
        {
            foreach (T value in array)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}
