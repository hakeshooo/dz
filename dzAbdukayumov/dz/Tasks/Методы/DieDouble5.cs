using System;
using System.Collections.Generic;
using System.Linq;


namespace RemoveDuplicatesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4 };


            List<int> uniqueNumbers = RemoveDuplicates(numbers);
            Console.WriteLine("Список без дубликатов: " + string.Join(", ", uniqueNumbers));
        }


        static List<int> RemoveDuplicates(List<int> numbers)
        {
            return numbers.Distinct().ToList();
        }
    }
}




