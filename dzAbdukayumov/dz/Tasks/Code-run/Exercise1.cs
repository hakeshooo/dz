using System;  // CodeRun: Юля, Никита и задачи
using System.Numerics;

public class TaskCounter
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        BigInteger a = BigInteger.Parse(input[0]);
        BigInteger b = BigInteger.Parse(input[1]);

        Console.WriteLine(a + b);
    }
}