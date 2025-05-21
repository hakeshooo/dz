using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = CalculateSum(numbers);
        Console.WriteLine($"Сумма чисел: {sum}"); // Выведет: Сумма чисел: 15
    }
    static int CalculateSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}
