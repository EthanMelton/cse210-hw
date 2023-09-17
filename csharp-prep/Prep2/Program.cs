using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);

        int x = percentage;
        string letter = "";

        if (x >= 90)
        {
           letter = "A"; 
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine("");
        Console.WriteLine($"Your letter grade is: {letter}");
        Console.WriteLine("");

        if (x >= 70)
        {   
            Console.WriteLine("You passed the class! Well Done!");
        }
        else
        {
            Console.WriteLine("Oh no! You did not pass! Better luck next time! :(");
        }
    }
}