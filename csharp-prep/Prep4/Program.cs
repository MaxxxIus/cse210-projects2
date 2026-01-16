using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int answer;
        do
        {
            Console.WriteLine("Please give a Number");
            Console.Write("Type 0 to stop: ");
            answer = int.Parse(Console.ReadLine());
            if (answer != 0)
            {
                numbers.Add(answer);
            }

        } while (answer != 0);

        int sum = 0;
        int largest = numbers[0];
        foreach (int number in numbers)
        {
            sum += number;
            if (largest < number)
            {
                largest = number;
            }
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {((float)sum) / numbers.Count}");
        Console.WriteLine($"Maximum: {largest}");




    }

    


}