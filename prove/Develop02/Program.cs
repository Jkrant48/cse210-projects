using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -1;

        Console.WriteLine("Welcome to the Journal Program!");//Welcom and generate menu for the user


        // new instance of the storeJournal class to add entries to the list and print them out
        Journal newEntry = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write \n2. Display \n3. Load \n4. Save \n5. Quit");
            Console.Write("What will you like to do? ");
            
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Console.WriteLine();
                    //new instance of userEntry class
                    UserEntry entry = new UserEntry();
                    //print out prompt
                    Console.WriteLine(entry._prompt);
                    // get userentry
                    Console.Write("> ");
                    entry._userResponse = Console.ReadLine();
                    Console.WriteLine();

                    // add entry to the list of entries
                    
                    newEntry._entries.Add(entry);
                    break;
                
                case 2:
                    Console.WriteLine();
                    // display the entries using the storeJournal class
                    
                    newEntry.displaySavedEntries();
                    break;
                
                case 3:
                    Console.Write("Please enter the name of the file (eg. myfile.txt): ");
                   
                    newEntry._fileName = Console.ReadLine().ToLower();
                    Console.WriteLine("loading from file...");

                    Console.WriteLine();
                    newEntry.loadJournal();
                    break;
                
                case 4:
                    // save the entries to a text file
                    Console.Write("Please enter a name for your file (eg. myfile.txt): ");
                    newEntry._fileName = Console.ReadLine().ToLower();
                   
                    Console.WriteLine();

                    Console.WriteLine("Saving to file...");
                    
                    newEntry.saveJournal();
                    Console.WriteLine("File has been saved successfully.");
                    break;

                case 5:
                    Console.WriteLine("Thank you");
                    break;
            }
        }while(userChoice != 5);

        
    }
}