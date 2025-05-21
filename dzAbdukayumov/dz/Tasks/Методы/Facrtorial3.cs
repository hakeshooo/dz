using System;


namespace FactorialApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Факториал: " + Factorial(n));
        }


        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
