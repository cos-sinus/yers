using HW3_4;
using System;
namespace HW3_3
{
    internal class TwoDemenshionArray<T> : BaseArray<T>
    {
        private Random random;
        private IValueProvider<T> _provider;
        private T[,] array;

        public TwoDemenshionArray(IValueProvider<T> provider)
        {
            _provider = provider;
            ReCreate();
        }

        public override void ArrayByUser()
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] rowscolumn = Console.ReadLine().Split();
            array = new T[int.Parse(rowscolumn[0]), int.Parse(rowscolumn[1])];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элементы строки");
                    string vvod = Console.ReadLine();
                    if (int.TryParse(vvod, out int value))
                    {
                        array[i, j] = _provider.GetUserValue();
                    }
                }
            }
        }

        public override void RandomArray()
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] rowscolumn = Console.ReadLine().Split();
            array = new T[int.Parse(rowscolumn[0]), int.Parse(rowscolumn[1])];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = _provider.GetRandomValue();
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}