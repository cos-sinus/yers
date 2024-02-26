﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    internal interface IOneDimenshionArray : IBaseArray
    {
        void GetendArray();
    }
    internal class OneDimenshionArray
    {
        public sealed class OneDemensionArray : BaseArray, IOneDimenshionArray
        {
            private int[] array;

            public OneDemensionArray(int Len)
            {
                CreateRandomArray();
            }

            public void CreateRandomArray(int Len)
            {
                Console.WriteLine("Введите длинну массива:");
                array = new int[Len];
                var random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-200, 200);
                }
            }

            public override void CreateRandomArray()
            {
                Console.WriteLine("Введите длинну массива:");
                array = new int[int.Parse(Console.ReadLine())];
                var random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-200, 200);
                }
            }

            public override void AverageValue()
            {
                int count = 0;
                for (int i = 0; i < array.Length; ++i)
                {
                    count += array[i];
                }
                Console.WriteLine("Average: " + count / array.Length);
            }

            public override void Print()
            {
                Console.WriteLine("Array:");
                Console.WriteLine(string.Join(" ", array));
            }

            public void GetendArray()
            {
                int newmassLength = array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        if (array[i] == array[j] && i != j)
                        {
                            newmassLength--;
                            break;
                        }
                    }
                }
                int[] newmass = new int[newmassLength];
                for (int i = 0; i < newmass.Length; i++)
                {
                    newmass[i] = int.MinValue;
                }
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (!Exist(array[i], newmass))
                    {
                        newmass[counter] = array[i];
                        counter++;
                    }
                }
                foreach (var elem in newmass)
                {
                    Console.Write(elem + " ");
                }
            }

            private bool Exist(int elem, int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == elem)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
