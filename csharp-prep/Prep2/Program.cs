using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask user for their grade percentage
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        // letter grade
        string letter;

        if (grade >= 90)
            letter = "A";

        else if (grade >= 80)
            letter = "B";

        else if (grade >= 70)
            letter = "C";

        else if (grade >= 60)
            letter = "D";
            
        else
            letter = "F";

        Console.WriteLine(letter);
        
        // a separate if and else statement for if the student passed
        if (grade >= 70)
            Console.WriteLine("Congratulations!! You passed.");
        else 
            Console.WriteLine("Don't give up! This is just a minor set back.");
        
    

    }
}