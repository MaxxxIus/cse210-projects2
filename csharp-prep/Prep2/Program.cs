using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        if (gradeInt >= 90)
        {
            grade = "A";
        } else if (gradeInt >= 80)
        {
            grade = "B";
        } else if (gradeInt >= 70)
        {
            grade = "C";
        } else if (gradeInt >= 60)
        {
            grade = "D";
        } else
        {
            grade = "F";
        }

        Console.WriteLine($"Your Letter Grade: {grade}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congrates!! You Passes!!!");
        } else
        {
            Console.WriteLine("Sorry, You Failed. See you Next Semester.");
        }
    }
}