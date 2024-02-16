using System;
class Program
{
    static void Main()
    {
        BaseArray[] array = new BaseArray[]
        {
            new OneDemensionArray(3),
            new TwoDemensionArray(2, 3),
            new JaggedArray(3)
        };

        foreach (var a in array)
        {
            a.CreateRandomArray();
            a.Print();
            a.AverageValue();
        }
    }
}

public interface IPrinter
{
    void Print();
}

public interface IBaseArray : IPrinter
{
    void CreateRandomArray();

    void CreateArray();

    void AverageValue();

    void Print();
}

public abstract class BaseArray : IBaseArray
{
    public abstract void CreateRandomArray();

    public abstract void CreateArray();

    public abstract void AverageValue();

    public abstract void Print();

    /*public Array(bool choise)
    {
        if (choise)
        {
            CreateRandomArray();
        }
        else
        {
            CreateArray();
        }
    }*/
}

public interface IOneDemensionArray : IBaseArray
{
    void GetendArray();
}

public sealed class OneDemensionArray : BaseArray, IOneDemensionArray 
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
public interface ITwoDemensionArray : IBaseArray
{
    void PrintMatricha();
}

public sealed class TwoDemensionArray : BaseArray, ITwoDemensionArray 
{
    private int[,] array;

    public TwoDemensionArray(int Len1, int Len2)
    {
        CreateRandomArray();
    }

    public override void CreateRandomArray(int Len1, int Len2)
    {
        Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
        string[] a = Console.ReadLine().Split();
        array = new int[Len1, Len2];
        var random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-200, 200);
            }
        }
    }

    public override void CreateRandomArray()
    {
        Console.WriteLine("Введите кол-во столбцов и срок в массиве:");
        string[] a = Console.ReadLine().Split();
        array = new int[int.Parse(a[0]), int.Parse(a[1])];
        var random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        int count = 0;
        for (int i = 0; i < array.GetLength(0); ++i)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                count += array[i, j];
            }
        }
        Console.WriteLine("Average: " + count / array.Length);
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"Row {i}: ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void PrintMatricha()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (i % 2 != 0)
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
public interface IJaggedArray : IBaseArray
{
    void IzmenArray();
}

public sealed class JaggedArray : BaseArray, IJaggedArray 
{
    private int[][] array;

    public JaggedArray()
    {
        CreateArray();
    }

    public override void CreateRandomArray()
    {
        Console.WriteLine("Введите кол-во строк в массиве:");
        array = new int[int.Parse(Console.ReadLine())][];
        var random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine("Введите длину строки:");
            array[i] = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(-200, 200);
            }
        }
    }

    public override void AverageValue()
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                count += array[i][j];
            }
        }
        Console.WriteLine("Average: " + count / array.Length);
    }

    public override void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < arraye.Length; i++)
        {
            Console.Write($"Row {i}: ");
            Console.WriteLine(string.Join(" ", array[i]));
        }
    }
    
    public void IzmenArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] % 2 == 0)
                {
                    array[i][j] = i * j;
                }
            }
        }
    }
}
