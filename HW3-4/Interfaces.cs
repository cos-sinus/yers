using System;
using System.Reflection;

namespace HW3_4
{
    internal interface IPrinter
    {
        void Print();
    }

    internal interface IBaseArray : IPrinter
    {
        void Print();
    }
}
