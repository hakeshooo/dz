using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal summa = decimal.Parse(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int mes = int.Parse(Console.ReadLine());

        decimal summaFinal = summa;
        int i = 0;

        do
        {
            summaFinal = summaFinal + (summaFinal * 0.07M);
            i++;
        }
        while (i < mes);

        Console.WriteLine("За " + mes + " месяц(ев) сумма вклада составила: " + summaFinal.ToString("F2"));
        Console.ReadKey();
    }
}