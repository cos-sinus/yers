using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal interface IBaseArray : IPrinter
    {
        void CreateRandomArray();

        void AverageValue();

        void Print();
    }
    abstract class BaseArray : IBaseArray
    {
        public abstract void CreateRandomArray();

        public abstract void AverageValue();

        public abstract void Print();
    }
}
