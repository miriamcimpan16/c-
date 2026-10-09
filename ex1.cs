
using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int suma = 0;

        for (int i = 0; i < n; i++)
        {
            int numar = int.Parse(Console.ReadLine()!);
            suma = suma + numar;
        }

        Console.WriteLine(suma);
    }
}