using System;
using System.ComponentModel;

class Program
{
    static string DisplayWelcome()
    {
        return "Welcome to the program! ";
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter favorite number: ");
        return int.Parse(Console.ReadLine());
        
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
       
    }

    
    static int SquareNumber()
    {
        int number = PromptUserNumber();
        int numberSquared = number * number;
        return numberSquared;

    }
    static string DisplayResult()
    {
        string message = DisplayWelcome();
        Console.WriteLine(message);

        string name = PromptUserName();

        int number = SquareNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int currentAge = 2025 - birthYear;

        Console.WriteLine($"{name}, the square of your number is {number}");
        Console.WriteLine($"{name}, you will turn {currentAge} this year. ");

        return $"{name}, the square of your number is {number}";
        
        
        
    }
    
    static void Main(string[] args)
    {

        string result = DisplayResult();

    }   


}