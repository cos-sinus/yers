using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;

namespace HW3_3
{
    public class OneDimenshionalArr<T>
    {
        public T[] arr;
        private int _size;
        private int _capacity;
        private Random rnd = new Random();

        public OneDimenshionalArr(int capacity)
        {
            _capacity = capacity;
            T[] arr = new T[_capacity];
            _size = 0;
        }

        public OneDimenshionalArr() : this(7)
        {
        }

        public void AddElem(T elem)
        {
            if (_size >= _capacity)
            {
                _capacity = 2 * _capacity + 1;
                T[] mass = new T[_capacity];
                Array.Copy(arr, mass, _size);
                arr = mass;
            }
            arr[_size] = elem;
            _size++;
        }

        public void Print()
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine(" ");
        }

        public void DelElem(int index)
        {
            if (index <= _size)
            {
                T[] array = new T[_capacity];
                for (int i = 0; i < _size; i++)
                {
                    if (i != index)
                    {
                        array[i] = arr[i];
                    }
                }
                _size--;
                arr = array;
            }
            else
            {
                Console.WriteLine("Index is out of range!");
            }
        }

        public void SortArr()
        {
            Array.Sort(arr, 0, _size);
        }

        public int CountElem()
        {
            return _size;
        }

        public int CountSomeElem(Func<T, bool> action)
        {
            int counter = 0;
            for (int i = 0; i < _size; i++)
            {
                if (action(arr[i]))
                {
                    counter++;
                }
            }
            return counter;
        }

        public bool IfElem(Func<T, bool> action)
        {
            for (int i = 0; i < _size; i++)
            {
                if (action(arr[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IfAllElems(Func<T, bool> action)
        {
            for (int i = 0; i < _size; i++)
            {
                if (!action(arr[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsElem(T elem)
        {
            for (int i = 0; i < _size; i++)
            {
                if (arr.Contains(elem))
                {
                    return true;
                }
            }
            return false;
        }

        public void FirstIfElem(Func<T, bool> action)
        {
            for (int i = 0; i < _size; i++)
            {
                if (action(arr[i]))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.WriteLine("Index is out of range!");
        }

        public void ActionOnArr(Func<T, T> action)
        {
            for (int i = 0; i < _size; i++)
            {
                Console.WriteLine(action(arr[i]));
            }
        }

        public void ElemsActionOnArr(Func<T, bool> action)
        {
            for (int i = 0; i < _size; i++)
            {
                if (action(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public void Rra()
        {
            Array.Reverse(arr, 0, _size);
        }

        public void MinMaxElem()
        {
            Array.Sort(arr, 0, _size);
            T min = arr[0];
            T max = arr[_size];
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
        }

        public void MinMaxElemByProection(Func<T, T> action)
        {
            for (int i = 0; i < _size; i++)
            {
                action(arr[i]);
            }
            Array.Sort(arr, 0, _size);
            T min = arr[0];
            T max = arr[_size];
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
        }

        public void ProjElemToNewType(Func<T, string> action)
        {
            arr.Select(action).ToArray();
        }

        public void GiveDiaposoneElems(int numofelems, int index)
        {
            for (int i = index; i < index + numofelems; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(" ");
            }
        }

        public void Iteration()
        {
            foreach (var elem in arr)
            {
                Console.Write(elem + " ");
            }
        }
    }
}