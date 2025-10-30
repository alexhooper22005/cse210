using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine($"{a.GetSummary()}");

        MathAssignment m = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine($"\n\n{m.GetHomeworkList()}");

        WritingAssignment w = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine($"\n\n{w.GetWritingInformation()}");


    }
}