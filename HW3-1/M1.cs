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


    private bool Exist(int elem, int[] mass)
    {
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] == elem)
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
            if (Math.Abs(mass[i]) > 100)
            {
                count += 1;
            }
        }
        int[] mass2 = new int[mass.Length - count];
        int x = 0;
        for (int i = 0; i < (mass.Length - count); i++)
        {
            if (Math.Abs(mass[i]) < 100)
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
        for (int i = 0; i < mass.Length; ++i)
        {
            count += mass[i];
        }
        Console.WriteLine(count / mass.Length);
    }
}