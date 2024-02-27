using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal interface IJaggedArray : IBaseArray
    {
        void IzmenArray();
    }
    internal class JaggedArray : BaseArray, IJaggedArray
    {
        private int[][] array;

        public JaggedArray(bool choise = false)
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
            Console.WriteLine("Введите кол-во строк в массиве:");
            array = new int[int.Parse(Console.ReadLine())][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("Введите строку:");
                    Console.Write($"Elem [{i},{j}]: ");
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }
        public override void RandomArray()
        {
            Console.WriteLine("Введите кол-во строк в массиве:");
            array = new int[int.Parse(Console.ReadLine())][];
            var random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine("Введите длину строки:");
                array[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(-200, 200);
                }
            }
        }

        public override void AverageValue()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    count += array[i][j];
                }
            }
            Console.WriteLine("Average: " + count / array.Length);
        }

        public override void Print()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Row {i}: ");
                Console.WriteLine(string.Join(" ", array[i]));
            }
        }

        public void IzmenArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
        }
    }
}
