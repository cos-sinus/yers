using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal interface ITwoDemenshoinArray : IBaseArray
    {
        void PrintMatricha();
    }
    internal class TwoDemenshionArray : BaseArray, ITwoDemenshoinArray
    {
        private int[,] array;

        public TwoDemenshionArray(int Len1, int Len2)
        {
            CreateRandomArray();
        }

        public void CreateRandomArray(int Len1, int Len2)
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] a = Console.ReadLine().Split();
            array = new int[Len1, Len2];
            var random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-200, 200);
                }
            }
        }

        public override void CreateRandomArray()
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] a = Console.ReadLine().Split();
            array = new int[int.Parse(a[0]), int.Parse(a[1])];
            var random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-200, 200);
                }
            }
        }

        public override void AverageValue()
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); ++i)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    count += array[i, j];
                }
            }
            Console.WriteLine("Average: " + count / array.Length);
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

        public void PrintMatricha()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                if (i % 2 != 0)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
