using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string firstName = PromptFirstName();
        string lastName = PromptLastName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResults(firstName, lastName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptFirstName()
    {
        Console.WriteLine("Please enter your first name: ");
        string name = Console.ReadLine();

        return name;
    }

    static string PromptLastName()
    {
        Console.WriteLine("Please enter your last name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string first, string last, int square)
    {
        Console.WriteLine($"Hey {first} {last}! The square of your number is {square}!");
    }
}   
