using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {   
        // Create a new list of numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number = -999;
        while (number != 0)
        {   
            // ask the user for the numbers
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // add the number to the list
            if (number != 0)
                numbers.Add(number);
        }

        /*Compute the total, average and find the largest number*/
        int sum = 0;
        
        foreach (int figure in numbers)
            sum += figure;

        decimal average = ((decimal)sum) / numbers.Count();

        int largestNumber = -99999;
        foreach (int figure in numbers)

            if (figure > largestNumber) 
                largestNumber = figure;

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The largest number is {largestNumber}");

    }
}