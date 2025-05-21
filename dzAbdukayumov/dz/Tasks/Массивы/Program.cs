using System;

namespace SimpleArrayPrinter
{
    class Program
    {
        static void Main()
        {
            int[,,] numbers = {
                { { 1, 2 }, { 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };

            Console.WriteLine("Содержимое трехмерного массива:");

            for (int block = 0; block < numbers.GetLength(0); block++)
            {
                Console.Write($"Блок {block + 1}: ");

                for (int row = 0; row < numbers.GetLength(1); row++)
                {
                    for (int num = 0; num < numbers.GetLength(2); num++)
                    {
                        Console.Write(numbers[block, row, num] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}