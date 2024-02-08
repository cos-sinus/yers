using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        static void Main()
        {
            Massive[] mass = new Massive[]
            {
                new OneDemensionMassive(3),
                new TwoDemensionMassive(2, 3),
                new JaggedMassive(3)
            };
            foreach (var m in mass)
            {
                m.CreateMassive();
                m.Print();
                m.AverageValue();
            }
        }
    }
}
