using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal interface IBaseArray : IPrinter
    {
        void ArrayByUser();

        void RandomArray();

        void AverageValue();

        void Print();
    }
    abstract class BaseArray : IBaseArray
    {
        public abstract void ArrayByUser();

        public abstract void RandomArray();

        public abstract void AverageValue();

        public abstract void Print();
    }
}
