using System;
public class HelloWorld
{
   public static void Main()
   {
       Console.WriteLine("Введите длину массива:");
       int Length = int.Parse(Console.ReadLine());
       Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
       bool choise = bool.Parse(Console.ReadLine());
       Mass1 mass = new Mass1(Length, choise);
       Console.WriteLine();
       Console.WriteLine("Среднее значение массива:");
       mass.GetSrZnach();
       Console.WriteLine("Все числа меньше 100 по модулю:");
       mass.Diapozon();
       Console.WriteLine("Не повторяющийся массив:");
       mass.Getendmass();
   }
}


class Mass1
{
   private int[] mass;


  public Mass1(int Length, bool choise = false)
  {
      if (choise)
      {
          Getmass(Length);
          Console.WriteLine("Массив:");
      }
        else
        {
            GetRandomMass(Length);
            Console.WriteLine("Массив:");
        }
        PrintMass();
  }


   private void Getmass(int Length)
   {
       Console.WriteLine("Введите элементы массива");
       string[] str = Console.ReadLine().Split();
       mass = new int[Length];
       for (int i = 0; i < str.Length; i++)
       {
           mass[i] = int.Parse(str[i]);
       }
   }


  private void GetRandomMass(int Length)
  {
      Random random = new Random();
      mass = new int[Length];
      for (int i = 0; i < Length; i++)
      {
          int elem = random.Next(0, 10);
          mass[i] = elem;
      }
  }


 private void PrintMass()
 {
     foreach (var elem in mass)
     {
         Console.Write(elem + " ");
     }
 }


   public void Getendmass()
   {
       int newmassLength = mass.Length;
       for(int i = 0; i < mass.Length; i++)
       {
           for(int j = i; j < mass.Length; j++)
           {
               if (mass[i] == mass[j] && i != j)
               {
                   newmassLength--;
                   break;
               }
           }
       }
       int[] newmass = new int[newmassLength];
       for(int i = 0; i < newmass.Length; i++)
       {
           newmass[i] = int.MinValue;
       }
        int counter = 0;
       for(int i = 0; i < mass.Length; i++)
       {
           if(!Exist(mass[i], newmass))
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


   private bool Exist(int elem, int[] mass)
   {
       for(int i = 0; i  < mass.Length; i++)
       {
           if(mass[i] == elem)
           {
               return true;
           }
       }
       return false;
   }


  public void Diapozon()
  {
      int count = 0;
      for (int i = 0; i < mass.Length; i++)
      {
          if (Math.Abs(mass [i]) > 100)
          {
              count += 1;
          }
      }
      int [] mass2 = new int [mass.Length - count];
      int x = 0;
      for (int i = 0; i < (mass.Length - count); i++)
      {
          if (Math.Abs(mass [i]) < 100)
          {
              mass2[x] = mass[i];
              x += 1;
          }
      }
      foreach (int elem in mass2)
      {
          Console.WriteLine(elem);
      }
  }


  public void GetSrZnach()
  {
      int count = 0;
      for (int i=0; i < mass.Length; ++i)
      {
          count += mass[i];
      }
      Console.WriteLine(count/mass.Length);
  }
}




using System;
public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Введите длину массива:");
        int massL1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите ширину массива:");
        int massL2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
        bool choise = bool.Parse(Console.ReadLine());
        Mass2 mass = new Mass2(massL1, massL2, choise);
        Console.WriteLine();
        Console.WriteLine("Среднее значение массива:");
        mass.GetSrZnach(massL1, massL2);
        Console.WriteLine();
        Console.WriteLine("Печать массива с элементами четных строк в обратном порядке:");
        mass.PrintMatricha(massL1, massL2);
    }
}


using System;
public class HelloWorld
{
   public static void Main()
   {
       Console.WriteLine("Введите длину по y массива:");
       int massL1 = int.Parse(Console.ReadLine());
       Console.WriteLine("Введите ширину по x массива:");
       int massL2 = int.Parse(Console.ReadLine());
       Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
       bool choise = bool.Parse(Console.ReadLine());
       Mass2 mass = new Mass2(massL1, massL2, choise);
       Console.WriteLine();
       Console.WriteLine("Среднее значение массива:");
       mass.GetSrZnach(massL1, massL2);
       Console.WriteLine();
       Console.WriteLine("Печать массива с элементами четных строк в обратном порядке:");
       mass.PrintMatricha(massL1, massL2);
   }
}


class Mass2
{
   public int[,] mass;




   public Mass2(int massL1, int massL2, bool choise = false)
   {
       if (choise)
       {
           Getmass(massL1, massL2);
           Console.WriteLine("Массив:");
       }
       else
       {
           GetRandomMass(massL1, massL2);
           Console.WriteLine("Массив:");
       }
       PrintMass(massL1, massL2);
   }


   private void Getmass(int massL1, int massL2)
   {
       mass = new int[massL1, massL2];
       for (int i = 0; i < massL1; i++)
       {
           Console.WriteLine("Введите элементы строки");
           string[] strs = Console.ReadLine().Split();
           for (int j = 0; j < massL2; j++)
           {
               mass[i, j] = int.Parse(strs[j]);
           }
       }
   }


   private void GetRandomMass(int massL1, int massL2)
   {
       Random random = new Random();
       mass = new int[massL1, massL2];
       for (int i = 0; i < massL1; i++)
       {
           for (int j = 0; j < massL2; j++)
           {
               int elem = random.Next(0, 10);
               mass[i, j] = elem;
           }
       }
   }


   public void PrintMatricha(int massL1, int massL2)
   {
       for (int i = 0; i < massL1; i++)
       {
           if(i % 2 == 0)
           {
               for (int j = 0; j < massL2; j++)
               {
                   Console.Write(mass[i, j] + " ");
               }
               Console.WriteLine();
           }
           if(i % 2 != 0)
           {
               for (int j = massL2 - 1; j >= 0; j--)
               {
                   Console.Write(mass[i, j] + " ");
               }
               Console.WriteLine();
           }
       }
   }


   public void PrintMass(int massL1, int massL2)
   {
       for (int i = 0; i < massL1; i++)
       {
           for (int j = 0; j < massL2; j++)
           {
               Console.Write(mass[i, j] + " ");
           }
           Console.WriteLine();
       }
   }


   public void GetSrZnach(int massL1, int massL2)
   {
       int count = 0;
       for (int i = 0; i < massL1; ++i)
       {
           for (int j = 0; j < massL2; j++)
           {
               count += mass[i, j];
           }
       }
       Console.WriteLine(count / mass.Length);
   }
}



using System;
public class HelloWorld
{
   public static void Main()
   {
       Console.WriteLine("Введите ширина массива:");
       int lenn = int.Parse(Console.ReadLine());
       Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
       bool choise = bool.Parse(Console.ReadLine());
       Mass3 mass = new Mass3(lenn, choise);
       Console.WriteLine();
       Console.WriteLine("Среднее значение массива:");
       mass.GetSrZnach();
       Console.WriteLine("Среднее значение строки массива:");
       mass.GetSrZnachOfStr();
       Console.WriteLine();
       Console.WriteLine("Печать массива с измененными элементами:");
       mass.IzmenMass();
   }
}


class Mass3
{
   public int[][] mass;


   public Mass3(int len, bool choise = false)
  {
        if (choise)
        {
            GetMass(len);
            Console.WriteLine("Массив:");
        }
        else
        {
            GetRandomMass(len);
            Console.WriteLine("Массив:");
        }
        Printmass();
    }


    private void GetMass(int len)
    {
        mass = new int[len][];
        for (int i = 0; i < len; i++)
        {
            int leng = int.Parse(Console.ReadLine());
            mass[i] = new int [leng];
            for(int j = 0; j < leng; j++)
            {
                Console.Write($"Elem [{i},{j}]: ");
                mass[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }


    private void GetRandomMass(int len)
    {
        Random random = new Random();
        mass = new int[len][];
        for (int i = 0; i < len; i++)
        {
            int leng = int.Parse(Console.ReadLine());
            mass[i] = new int [leng];
            for(int k = 0; k < leng; k++)
            {
                int elem = random.Next(0, 10);
                mass[i][k] = elem;
            }
        }
    }


    private void Printmass()
    {
        for(int i = 0; i < mass.Length; i++)
        {
            foreach(int it in mass[i])
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }


    public void IzmenMass( )
    {
        for (int i = 0; i < mass.Length; i++)
        {
            for (int j = 0; j < mass[i].Length; j++)
            {
                if(mass[i][j] % 2 == 0)
                {
                    mass[i][j] = i * j;
                }
            }
        }
        Printmass();
    }


    public void GetSrZnach()
    {
       int count = 0;
       for (int i = 0; i < mass.Length; i++)
       {
           for (int j = 0; j < mass[i].Length; j++)
           {
               count += mass[i][j];
           }
       }
       Console.WriteLine(count/mass.Length);
    }


    public void GetSrZnachOfStr()
    {
       int count = 0;
       for (int i = 0; i < mass.Length; i++)
       {
           for (int j = 0; j < mass[i].Length; j++)
           {
               count += mass[i][j];
           }
           Console.WriteLine(count/mass.Length);
       }
    }
}
