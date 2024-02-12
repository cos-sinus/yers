user System;

public interface IPrinter
{
    public Print();
}

public interface IArray : IPrinter
{
    void CreateRandomArray();

    void CreateArray();

    void AverageValue();

    void Print();
}

public abstract class Array : IArray
{
    public abstract void CreateRandomArray();

    public abstract void CreateArray();

    public abstract void AverageValue();

    public abstract void Print();

    public Array(bool choise)
    {
        if (choise)
        {
            CreateRandomArray();
        }
        else
        {
            CreateArray();
        }
    }
}

public interface IOneDemensionArray : IArray
{
    void GetendArray();
}

public sealed class OneDemensionArray : Array, IOneDemensionArray 
{
        private int[] massive;

        public OneDemensionMassive(int Len)
        {
            CreateMassive();
        }

        public void CreateMassive(int Len)
        {
            Console.WriteLine("Введите длинну массива:");
            massive = new int[Len];
            var random = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(-200, 200);
            }
        }

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
            Console.WriteLine("Average: " + count / massive.Length);
        }

        public override void Print()
        {
            Console.WriteLine("Array:");
            Console.WriteLine(string.Join(" ", massive));
        }
        
        public void Getendmass()
        {
        int newmassLength = mass.Length;
        for (int i = 0; i < mass.Length; i++)
        {
            for (int j = i; j < mass.Length; j++)
            {
                if (mass[i] == mass[j] && i != j)
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
        for (int i = 0; i < mass.Length; i++)
        {
            if (!Exist(mass[i], newmass))
            {
                newmass[counter] = mass[i];
                counter++;
            }
        }
        foreach (var elem in newmass)
        {
            Console.Write(elem + " ");
        }
    }
}
