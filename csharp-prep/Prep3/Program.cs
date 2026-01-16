using System;
using System.Diagnostics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int answer;

        do
        {
            Console.Write("What is your guess between 1 and 100? ");
            answer = int.Parse(Console.ReadLine());

            if (answer < number)
            {
                Console.WriteLine("Higher");
            } else if (answer > number)
            {
                Console.WriteLine("Lower");
            }   else if (answer == number)
            {
                Console.WriteLine("Thats Correct!!!");
            } else
            {
                Console.WriteLine("Invalide Response");
            }
        } while (answer != number);
    }
}