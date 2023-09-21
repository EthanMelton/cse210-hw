using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //created new list: numbers
        List<int> numbers = new List<int>();

        //initializing the variable: userNumber
        int userNumber = -1;

        //while loop start
        while (userNumber != 0)
        {
            //user input
            Console.Write("Please enter a number. (Enter 0 to quit): ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            //if statement that adds a number if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // initializing the variable: sum
        int sum = 0;

        //foreach loop start
        foreach (int number in numbers)
        {
            sum += number;
        }

        //sum output line
        Console.WriteLine($"The sum of the numbers is: {sum}");

        //average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        //initializing the variable: max ... this is done by starting at the first number in the list.
        int max = numbers[0];

        //another foreach loop
        foreach (int number in numbers)
        {
            if (number > max)
                {
                    //what this essentially does is that whenever a number is bigger than what the previous max is,
                    //it sets the max to that new number. 
                    max = number;
                }
        }

        //console write line for max
        Console.WriteLine($"The maximum of the numbers in the list is: {max}");
        
    }
}