using System;

class Program
{
    static void Main(string[] args)
    {
        
        string response = "yes";

        do
        {

        Random randomNumber = new Random();
        int winningNumber = randomNumber.Next(1, 101);
        int guess = 0;
        int guessAmount = 0;

            while (guess != winningNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > winningNumber)
                {
                    Console.WriteLine("Lower!");
                    guessAmount += 1;
                }
                else if (guess < winningNumber)
                {
                    Console.WriteLine("Higher!");
                    guessAmount += 1;
                }
                else
                {
                    Console.WriteLine("You Guessed it!");
                    guessAmount += 1;
                }
            }

            Console.WriteLine($"You got the Winning Number in {guessAmount} guesses!");
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}