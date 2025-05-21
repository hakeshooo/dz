using System;
using System.Collections.Generic;


namespace MaxElementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 3, 7, 1, 9, 4 };


            Console.WriteLine("Максимальный элемент: " + FindMax(numbers));
        }


        static int FindMax(List<int> numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}
