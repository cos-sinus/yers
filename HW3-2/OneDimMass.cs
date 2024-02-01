using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    public sealed class OneDemensionMassive : Massive
    {
        private int[] massive;

        public override void CreateMassive()
        {
            Console.WriteLine("Введите длинну массива:");
            massive = new int[int.Parse(Console.ReadLine())];
            var random = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(-200, 200);
            }
        }

        public override void AverageValue()
        {
            int count = 0;
            for (int i = 0; i < massive.Length; ++i)
            {
                count += massive[i];
            }
            Console.WriteLine("Average" + count / massive.Length);
        }

        public override void Print()
        {
            Console.WriteLine("Array:");
            Console.WriteLine(string.Join(" ", massive));
        }
    }
}
