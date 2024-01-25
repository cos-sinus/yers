using System;
public class HelloWorld
{
    public static void Main()
    {
        Console.WriteLine("Введите длину массива:");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
        bool choise = bool.Parse(Console.ReadLine());
        Mass1 mass1 = new Mass1(length, choise);
        Console.WriteLine();
        Console.WriteLine("Среднее значение массива:");
        mass1.GetSrZnach();
        Console.WriteLine("Все числа меньше 100 по модулю:");
        mass1.Diapozon();
        Console.WriteLine("Не повторяющийся массив:");
        mass1.Getendmass();

        Console.WriteLine("Введите длину массива:");
        int massL1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите ширину массива:");
        int massL2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
        choise = bool.Parse(Console.ReadLine());
        Mass2 mass2 = new Mass2(massL1, massL2, choise);
        Console.WriteLine();
        Console.WriteLine("Среднее значение массива:");
        mass2.GetSrZnach(massL1, massL2);
        Console.WriteLine();
        Console.WriteLine("Печать массива с элементами четных строк в обратном порядке:");
        mass2.PrintMatricha(massL1, massL2);

        Console.WriteLine("Введите ширина массива:");
        int lenn = int.Parse(Console.ReadLine());
        Console.WriteLine("Выбирите способ заполнения(true - с клавиатуры, false - автоматически):");
        choise = bool.Parse(Console.ReadLine());
        Mass3 mass3 = new Mass3(lenn, choise);
        Console.WriteLine();
        Console.WriteLine("Среднее значение массива:");
        mass3.GetSrZnach();
        Console.WriteLine("Среднее значение строки массива:");
        mass3.GetSrZnachOfStr();
        Console.WriteLine();
        Console.WriteLine("Печать массива с измененными элементами:");
        mass3.IzmenMass();
    }
}