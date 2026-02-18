using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment as1 = new MathAssignment("James", "Calculas", "8.4", "3-10");
        Console.WriteLine(as1.GetSummary());
        Console.WriteLine(as1.GetHomeworkList());
        Console.WriteLine("");
        WritingAssignment as2 = new WritingAssignment("Cole", "Eels", "The Day In The Life of an Eel");
        Console.WriteLine(as2.GetSummary());
        Console.WriteLine(as2.GetWritingInformation());
    }
}