
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private string _prompt;
    private List<string> _userEntries;
    private Random _random;

    public ListingActivity() : base ("Listing activity")
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random();

        _prompt = GeneratePrompt();

        _userEntries = new List<string>{};
    }

    public void RunListeningActivity()
    {
        Console.WriteLine(GetWelcomeMessage());
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Enter activity duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Get ready");
        Pause();
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"----- {_prompt} -----");
        Console.Write("You may begin in: ");
        CountDown();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            String userEntry = Console.ReadLine();
            _userEntries.Add(userEntry);

        }
        Console.WriteLine();

        Console.WriteLine(DisplayUserEntries());

    }

    private string GeneratePrompt()
    {
        int randomNumber = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }
    
    private string DisplayUserEntries()
    {
        string savedUserEntry = " ";

        foreach (string entry in _userEntries)
        {
            savedUserEntry = entry;
        }
        
        return savedUserEntry;
    }
    
}