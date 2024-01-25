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
            if (i % 2 == 0)
            {
                for (int j = 0; j < massL2; j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            if (i % 2 != 0)
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