using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int value = int.Parse(valueFromUser);

        string letter = "";

        if (value >= 90)
        {
            letter = "A";
        }
        else if (value >= 80)
        {
            letter = "B";
        }
        else if (value >= 70)
        {
            letter = "C";
        }
        else if (value >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (value >= 70)
        {   
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time.");
        }
    }
}