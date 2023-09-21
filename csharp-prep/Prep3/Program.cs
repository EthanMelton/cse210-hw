using System;

class Program
{
    static void Main(string[] args)
    {
        //boolean variable
        string response = "yes";

        //do while loop
        do
        {
        
        //creating random variable
        Random randomNumber = new Random();
        int winningNumber = randomNumber.Next(1, 101);
        
        //creating guess variable and guessAmount variable
        int guess = 0;
        int guessAmount = 0;

            while (guess != winningNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                //if statement that tells user to go lower
                if (guess > winningNumber)
                {
                    Console.WriteLine("Lower!");
                    guessAmount += 1;
                }
                //else if statement that tells user to go higher
                else if (guess < winningNumber)
                {
                    Console.WriteLine("Higher!");
                    guessAmount += 1;
                }
                //else statement that tells user that they won
                else
                {
                    Console.WriteLine("You Guessed it!");
                    guessAmount += 1;
                }
            }

            //statement telling user how many guesses they got the number in
            Console.WriteLine($"You got the Winning Number in {guessAmount} guesses!");

            //question asking if the user wants to continue
            Console.Write("Do you want to continue? ");

            //this is where the response is determined.
            response = Console.ReadLine();

        } while (response == "yes");
    }
}