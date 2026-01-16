using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to The Program!!!");
    }
    static string PromptUserName()
    {
        Console.Write("What is Your Name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("What is Your Favorite Number? ");
        return int.Parse(Console.ReadLine());
    }

    static void PromtUserBirthYear(out int year)
    {
        Console.Write("What is Your Birth Year? ");
        year = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int number, int year)
    {
        Console.WriteLine($"Your Name is {name}");
        Console.WriteLine($"Your Favorite Number Squared is {number}");
        int currentYear = DateTime.Now.Year;
        Console.WriteLine($"{name}, You will be {currentYear - year} this year");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int year;
        PromtUserBirthYear(out year);
        number = SquareNumber(number);
        DisplayResult(name, number, year);
    }

}