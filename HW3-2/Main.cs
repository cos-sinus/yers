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
            Massive[] mass = new Massive[3];
            OneDemensionMassive o = new OneDemensionMassive();
            TwoDemensionMassive t = new TwoDemensionMassive();
            JaggedMassive s = new JaggedMassive();
            mass[0] = o;
            mass[1] = t;
            mass[2] = s;
            foreach (var m in mass)
            {
                m.CreateMassive();
                m.Print();
                m.AverageValue();
            }
        }
    }
}
