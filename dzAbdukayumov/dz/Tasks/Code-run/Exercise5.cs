using System; //CodeRun: 29 задача аналитики

public class QuadraticEquation
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine(0);
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine(1);
            Console.WriteLine($"{x:F6}");
        }
        else
        {
            double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine(2);
            Console.WriteLine($"{Math.Min(x1, x2):F6} {Math.Max(x1, x2):F6}");
        }
    }
}