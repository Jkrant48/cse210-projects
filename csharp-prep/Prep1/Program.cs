using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {   
        // prompt user for their first name and last name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}