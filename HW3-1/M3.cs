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
            mass[i] = new int[leng];
            for (int j = 0; j < leng; j++)
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
            mass[i] = new int[leng];
            for (int k = 0; k < leng; k++)
            {
                int elem = random.Next(0, 10);
                mass[i][k] = elem;
            }
        }
    }


    private void Printmass()
    {
        for (int i = 0; i < mass.Length; i++)
        {
            foreach (int it in mass[i])
            {
                Console.Write(it + " ");
            }
            Console.WriteLine();
        }
    }


    public void IzmenMass()
    {
        for (int i = 0; i < mass.Length; i++)
        {
            for (int j = 0; j < mass[i].Length; j++)
            {
                if (mass[i][j] % 2 == 0)
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
        Console.WriteLine(count / mass.Length);
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
            Console.WriteLine(count / mass.Length);
        }
    }
}