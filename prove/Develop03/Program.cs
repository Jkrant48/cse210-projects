//scripture memorizer program

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome! \nThis is the Scripture memorizer program.");
        
        int userResponse = -1;

        Scriptures learnScripture = new Scriptures();

        ScriptureReader readScripture = new ScriptureReader();

        Words word = new Words();

        do {
            Console.WriteLine("Choose from the menu below: ");
            Console.WriteLine("1. Add scripture \n2. Display saved scriptures \n3. Memorize \n4. Quit");
            Console.WriteLine();

            Console.Write("> ");
            userResponse = int.Parse(Console.ReadLine());

            switch (userResponse) {
                case 1:
                    Console.Write("Please enter a scripture you want to memorize: ");
                    
                    string script = Console.ReadLine();
                    // save scriptures added to the list
                    learnScripture.SaveScriptures(script);
                break;
                case 2:
                    
                    readScripture.LoadFromFile();

                    Console.WriteLine();

                    word.displayscripture(readScripture.separatedScripture());

                break;
                case 3:
                    
                    word.memorizeScripture(readScripture.separatedScripture());

                break;
                case 4:
                    Console.WriteLine("Thank you!");
                break;
            }
        
        } while (userResponse != 4);
        
    }
}