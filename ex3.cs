
using System;

class Student
{
    private readonly string name;
    private readonly int year;
    private readonly double grade1;
    private readonly double grade2;
    private readonly double grade3;

    public Student(string name, int year, double grade1, double grade2, double grade3)
    {
        this.name = name;
        this.year = year;
        this.grade1 = grade1;
        this.grade2 = grade2;
        this.grade3 = grade3;
    }

    public double Average
    {
        get { return (grade1 + grade2 + grade3) / 3; }
    }

    public override string ToString()
    {
        return "Nume: " + name +
               ", An: " + year +
               ", Nota 1: " + grade1 +
               ", Nota 2: " + grade2 +
               ", Nota 3: " + grade3 +
               ", Media: " + Average;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Introduceti numarul de studenti: ");
        int n = int.Parse(Console.ReadLine()!);

        Student[] studenti = new Student[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nStudentul " + (i + 1) + ":");

            Console.Write("Introduceti numele: ");
            string name = Console.ReadLine()!;

            Console.Write("Introduceti anul de studiu: ");
            int year = int.Parse(Console.ReadLine()!);

            Console.Write("Introduceti prima nota: ");
            double grade1 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduceti a doua nota: ");
            double grade2 = double.Parse(Console.ReadLine()!);

            Console.Write("Introduceti a treia nota: ");
            double grade3 = double.Parse(Console.ReadLine()!);

            studenti[i] = new Student(name, year, grade1, grade2, grade3);
        }

        Student celMaiBun = studenti[0];

        for (int i = 1; i < n; i++)
        {
            if (studenti[i].Average > celMaiBun.Average)
            {
                celMaiBun = studenti[i];
            }
        }

        Console.WriteLine("\nStudentul cu media cea mai mare este:");
        Console.WriteLine(celMaiBun);
    }
}