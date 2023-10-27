using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("7.3", "8-19", "Roberto Rodriguez", "Fractions");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The causes of world war II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());


    }
}