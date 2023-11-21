using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!!");
        Console.WriteLine("This program helps you sets goals and when you achieve your goal, you are awarded points. ");
        
        
        EternalQuest eternalQuest = new EternalQuest();
        

        int goalTypeChoice;
        int userChoice;
        do 
        {   
            Console.WriteLine();
            eternalQuest.DisplayTotalPoints();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Quit");
            
            Console.WriteLine();
            Console.Write("Select an option from the menu: ");
            userChoice = int.Parse(Console.ReadLine());
            
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("The types of Goal are: ");
                    Console.WriteLine("1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal");
                    Console.Write("Which type of Goal would you like to create? ");
                    goalTypeChoice = int.Parse(Console.ReadLine());

                    switch (goalTypeChoice)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal("DefaultName", "DefaultDescription", 0);
                            simpleGoal.StartingMessage();
                            eternalQuest.AddGoal(simpleGoal);

                            
                        break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal("DefaultName", "DefaultDescription", 0);
                            eternalGoal.StartingMessage();
                            eternalQuest.AddGoal(eternalGoal);
                            
                        break;
                        case 3:
                            ChecklistGoal checklistGoal = new ChecklistGoal("DefaultName", "DefaultDescription", 0);
                            checklistGoal.StartingMessage();
                            eternalQuest.AddGoal(checklistGoal);
                            
                        break;
                    }
                break;
                case 2:
                    eternalQuest.DisplayGoal();
                break;
                case 3:
                    Console.Write("What is the name of the file you want to save? ");
                    string fileName = Console.ReadLine();
                    eternalQuest.SaveGoalsTofile(fileName);
                    Console.WriteLine();
                    Console.Write("Saving to file");
                    loading();
                    Console.WriteLine();
                    Console.WriteLine("File saved successfully!");
                break;
                case 4:
                    Console.Write("What is the name of the file you want to load? ");
                    fileName = Console.ReadLine();
                    eternalQuest.LoadGoalsFromFile(fileName);
                    Console.WriteLine();
                    Console.Write("Loading from file");
                    loading();
                    Console.WriteLine();
                    Console.WriteLine("File loaded successfully!");
                break;
                case 5:
                    eternalQuest.DisplayForRecordEvent();
                    eternalQuest.RecordEvent();
                break;
                case 6:
                    Console.WriteLine("Finished!!");
                break;
            }
            

        }while (userChoice != 6);
    }

    public static void loading()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}

