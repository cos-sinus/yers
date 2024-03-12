using System;

namespace HW3_4
{
    public interface IValueProvider<T>
    {
        T GetUserValue();
        T GetRandomValue();
    }

    class ProvValInt : IValueProvider<int>
    {
        public int GetRandomValue()
        {
            Random random = new Random();
            int rnd = random.Next(0, 10);
            return rnd;
        }
        public int GetUserValue()
        {
            Random random = new Random();
            int rnd = int.Parse(Console.ReadLine());
            return rnd;
        }
    }

    class ProvValStr : IValueProvider<string>
    {
        public string GetUserValue()
        {
            return Console.ReadLine();
        }
        public string GetRandomValue()
        {
            char[] CharArray = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random random = new Random();
            char[] array1 = new char[10];
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(0, 26);
                array1[i] = CharArray[number];
            }
            return new string(array1);

        }
    }

    class ProvValDoub : IValueProvider<double>
    {
        public double GetUserValue()
        {
            return double.Parse(Console.ReadLine());
        }
        public double GetRandomValue()
        {
            Random random = new Random();

            int value = random.Next(10, 100000);
            int length = value.ToString().Length;
            double number = value / (10 * (length - 1));

            return number;
        }
    }

    class ProvValBool : IValueProvider<bool>
    {
        public bool GetUserValue()
        {
            return bool.Parse(Console.ReadLine());
        }
        public bool GetRandomValue()
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            return value == 0;
        }
    }
}
