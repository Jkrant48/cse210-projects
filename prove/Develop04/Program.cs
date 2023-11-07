using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfulness Program!");

        
        int userResponse = -1;
        do {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity \n2. Start reflection activity \n3. Start listing activity \n4. Gratitude Journal \n5. Quit");
            Console.Write("Select a choice from the menu options: ");

            userResponse = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (userResponse) 
            {
                case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.RunBreathingActivity();
                break;
                case 2:
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.RunReflectionActivity();
                break;
                case 3:
                ListingActivity listeningActivity = new ListingActivity();
                listeningActivity.RunListeningActivity();
                break;
                case 4:
                GratitudeJournalActivity gratitudeJournalActivityActivity = new GratitudeJournalActivity();
                gratitudeJournalActivityActivity.RunGratitudeJournalActivity();
                break;
                case 5:
                Console.WriteLine("Thank you. Always make time to relax, breath and reflect.");
                break;
            }
        }while (userResponse != 5);

    }
}