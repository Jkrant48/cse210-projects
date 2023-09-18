using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // call the functions to execute the program
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUSerNumber();

        int number2 = SquareNumber(number);

        DisplayResult(name, number2);
    }

    // function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    //function to prompt user for name

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUSerNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());

        return favoriteNumber;
    }

    static int SquareNumber(int Number)
    {
        int squarednumber = Number * Number;

        return squarednumber;
    }

    static void DisplayResult(string Name, int Numbersquared)
    {
        Console.WriteLine($"{Name}, the square of your number is {Numbersquared}");
    }
}   