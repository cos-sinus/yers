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

        public TwoDemenshionArray(bool choise = false)
        {
            if (choise)
            {
                ArrayByUser();
            }
            else
            {
                RandomArray();
            }
        }

        public override void ArrayByUser()
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] a = Console.ReadLine().Split();
            array = new int[int.Parse(a[0]), int.Parse(a[1])];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Введите элементы строки");
                string[] strs = Console.ReadLine().Split();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = int.Parse(strs[j]);
                }
            }
        }

        public override void RandomArray()
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
                int Index = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        Index = j;
                    }
                    else
                    {
                        Index = array.GetLength(1) - 1 - j;
                    }
                    Console.Write(array[i, Index] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}