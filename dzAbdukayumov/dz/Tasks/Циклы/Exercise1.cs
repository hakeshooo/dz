using System;

class Program
{
    static void Main()
    {
        decimal procent = 7m / 100m;

        Console.WriteLine("Процентная ставка банка равна 7%/мес.");
        Console.Write("Введите сумму вклада: ");

        decimal summ;
        string input = Console.ReadLine();
        summ = decimal.Parse(input);

        Console.Write("Введите количество месяцев: ");

        decimal month;
        input = Console.ReadLine();
        month = decimal.Parse(input);

        decimal res = summ;
        int months = (int)month;

        while (months > 0)
        {
            res = res + (res * procent);
            months = months - 1;
        }

        Console.WriteLine("Итоговая сумма равна: " + res.ToString("F2"));
    }
}