using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Калькулятор с операциями: +, -, *, /, %, ++, --");

                Console.Write("Введите первое число: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число (для ++/-- не важно): ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите операцию: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"Результат: {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"Результат: {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"Результат: {a * b}");
                        break;
                    case "/":
                        if (b != 0)
                            Console.WriteLine($"Результат: {a / b}");
                        else
                            Console.WriteLine("Ошибка: деление на ноль!");
                        break;
                    case "%":
                        if (b != 0)
                            Console.WriteLine($"Результат: {a % b}");
                        else
                            Console.WriteLine("Ошибка: деление на ноль!");
                        break;
                    case "++":
                        Console.WriteLine($"Результат: {a + 1} и {b + 1}");
                        break;
                    case "--":
                        Console.WriteLine($"Результат: {a - 1} и {b - 1}");
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
        }
    }
}