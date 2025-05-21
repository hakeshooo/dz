using System; //CodeRun: Выставление тегов

public class TagTime
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] t = new long[n];
        long totalTime = 0;

        if (n >= 1)
        {
            t[0] = 1;
            totalTime += t[0];
        }
        if (n >= 2)
        {
            t[1] = 1;
            totalTime += t[1];
        }

        for (int i = 2; i < n; i++)
        {
            t[i] = t[i - 1] + t[i - 2];
            totalTime += t[i];
        }

        Console.WriteLine(totalTime);
    }
}