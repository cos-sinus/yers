using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    public sealed class TwoDemensionMassive : Massive
    {
        private int[,] massive;

        public TwoDemensionMassive(int Len1, int Len2)
        {
            CreateMassive();
        }

        public void CreateMassive(int Len1, int Len2)
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] a = Console.ReadLine().Split();
            massive = new int[Len1, Len2];
            var random = new Random();
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = random.Next(-200, 200);
                }
            }
        }

        public override void CreateMassive()
        {
            Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
            string[] a = Console.ReadLine().Split();
            massive = new int[int.Parse(a[0]), int.Parse(a[1])];
            var random = new Random();
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    massive[i, j] = random.Next(-200, 200);
                }
            }
        }

        public override void AverageValue()
        {
            int count = 0;
            for (int i = 0; i < massive.GetLength(0); ++i)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    count += massive[i, j];
                }
            }
            Console.WriteLine("Average: " + count / massive.Length);
        }

        public override void Print()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                Console.Write($"Row {i}: ");
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write(massive[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
