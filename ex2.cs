
using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()!);
        double b = double.Parse(Console.ReadLine()!);
        double c = double.Parse(Console.ReadLine()!);

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    Console.WriteLine("Infinit de multe solutii");
                else
                    Console.WriteLine("Nu exista solutii");
            }
            else
            {
                double x = -c / b;
                Console.WriteLine("x = " + x);
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x = " + x);
            }
            else
            {
                Console.WriteLine("Nu exista solutii reale");
            }
        }
    }
}