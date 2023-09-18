using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        // guess my number game
        
        Console.WriteLine("Welcome to the Guess my number game.\nThe Computer generates a random number and you guess it.");
        Console.WriteLine("Enjoy!!");

        Random random = new Random();
        int magicNumber = random.Next(1,100);


        // let the user guess the number(add a loop to keep the game running)
        int guesses = 0; /*Calculate the total number of guesses and display for the user*/
        int guess = -1;
        while (guess != magicNumber)
        {
            guesses++;
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
                Console.WriteLine("Higher");

            else if (guess > magicNumber)
                Console.WriteLine("Lower");

            else if (guess == magicNumber)
                Console.WriteLine("You guessed correctly!");
        }
        Console.WriteLine($"You guessed {guesses} times.");

        
    }
}