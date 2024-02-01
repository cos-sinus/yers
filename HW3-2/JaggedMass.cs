using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    public sealed class JaggedMassive : Massive
    {
        private int[][] massive;

        public override void CreateMassive()
        {
            Console.WriteLine("Введите кол-во строк в массиве:");
            massive = new int[int.Parse(Console.ReadLine())][];
            var random = new Random();
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                Console.WriteLine("Введите длину строки:");
                massive[i] = new int[int.Parse(Console.ReadLine())];
                for (int j = 0; j < massive[i].Length; j++)
                {
                    massive[i][j] = random.Next(-200, 200);
                }
            }
        }

        public override void AverageValue()
        {
            int count = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = 0; j < massive[i].Length; j++)
                {
                    count += massive[i][j];
                }
            }
            Console.WriteLine("Average" + count / massive.Length);
        }

        public override void Print()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"Row {i}: ");
                Console.WriteLine(string.Join(" ", massive[i]));
            }
        }
    }
}
