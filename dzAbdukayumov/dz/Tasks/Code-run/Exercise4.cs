using System; //CodeRun: Больше своих соседей
using System.Linq;

public class CountElements
{
    public static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = 0;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}