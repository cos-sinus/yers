using System;

public abstract class Massive
{
    public abstract void CreateMassive();

    public abstract void AverageValue();

    public abstract void Print();
}

public sealed class OneDemensionMassive : Massive
{
    private int[] massive;

    public override void CreateMassive()
    {
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
        Console.WriteLine(count / massive.Length);
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(" ", massive));
    }
}

public sealed class TwoDemensionMassive : Massive
{
    private int[,] massive;

    public override void CreateMassive()
    {
        string[] a = Console.ReadLine().Split();
        massive = new int[int.Parse(a[0]), int.Parse(a[1])];
        var random = new Random();
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                massive[i, j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        int count = 0;
        for (int i = 0; i < massive.GetLength(0); ++i)
        {
            for (int j = 0; j < massive.GetLenght(1); j++)
            {
                count += mass[i, j];
            }
        }
        Console.WriteLine(count / mass.Length);
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < massive.GetLength(1); j++)
            {
                Console.Write(massive[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

public sealed class JaggedMassive : Massive
{
    private int[][] massive;

    public override void CreateMassive()
    {
        massive = new int[int.Parse(Console.ReadLine())][];
        var random = new Random();
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            massive[i] = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < massive[i].Length; j++)
            {
                massive[i][j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        int count = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            for (int j = 0; j < mass[i].Length; j++)
            {
                count += mass[i][j];
            }
        }
        Console.WriteLine(count / mass.Length);
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < massive.Length; i++)
        {
            Console.Write($"Row {i}: ");
            Console.WriteLine(string.Join(" ", massive[i]));
        }
    }
}

class Program
{
    static void Main()
    {
        Massive[] mass = new Massive[3];
        OneDemensionMassive o = new OneDemensionMassive();
        TwoDemensionMassive t = new TwoDemensionMassive();
        JaggedMassive s = new JaggedMassive();
        m[0] = o;
        m[1] = t;
        m[2] = s;
        foreach (var m in mass)
        {
            m.CreateMassive();
            m.Print();
            m.AverageValue();
        }
    }
}
