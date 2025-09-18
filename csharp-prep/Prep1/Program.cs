using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your first name? ");
        // string firstName = Console.ReadLine();
        // Console.Write("What is your last name? ");
        // string lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        Console.Write("What is your grade percentage? ");
        string numberFromUser = Console.ReadLine();

        int x = int.Parse(numberFromUser);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string letter = "";

        if (x >= a)
        {
            letter = "A";
        }
        else if (x >= b && x <= a)
        {
            letter = "B";
        }
        else if (x >= c && x <= b)
        {
            letter = "C";
        }
        else if (x >= d && x <= c)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (x >= d)
        {
            Console.WriteLine("You Passed! Congradulations!");
        }
        else
        {
            Console.WriteLine("You failed. Try again next time!");

        }

        Console.WriteLine($"Your grade letter is {letter}");
    }
    //     string firstName = "Bob";

    //     Console.WriteLine("Hello " + firstName);
    //     Console.WriteLine($"Hello {firstName}");
    //     Console.Write($"Hello {firstName}");
    //     Console.Write("This is a new test line\n");

    //     Console.Write("What is your favorite color? ");
    //     string favoriteColor = Console.ReadLine();

    //     Console.Write("How old are you? ");
    //     int age = int.Parse(Console.ReadLine());

    //     Console.WriteLine($"{firstName}, you are {age} years old, and your favorite color is {favoriteColor}");

    //     int a = 13;
    //     int b = 7;

    //     int c = a + b;

    //     Console.WriteLine($"c is {c}");
    //     Console.WriteLine($"a/b is {a / b}");
    //     Console.WriteLine($"{(double)a / b}");

    //     double x = 1.5;
    //     float y = 1.5f;

    //     bool isDone = false;

    //     if (isDone)
    //     {
    //         Console.WriteLine("All done.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Not done yet.");
    //     }

    // }
    
}