
public class GratitudeJournalActivity : Activity
{
    private List<string> _prompts;
    private List<string> _entries;
    private Random _random;
    private string _prompt;


    public GratitudeJournalActivity() : base ("Gratitude Journal Activity")
    {
        _prompts = new List<string>
        {
            "List three things in nature that you are grateful for.",
            "What achievements are you grateful for?",
            "What makes you smile and feel thankful?",
            "Who are you grafeful in your life?",
            "List things that happened today, that you are grateful for."
        };

        _entries = new List<string>{};

        _description = "This activity is intended to help you reflect on aspects of your life you are grafeful for.";

        _random = new Random();

        _prompt = GeneratePrompt(); 
    }

    public void RunGratitudeJournalActivity()
    {
        Console.WriteLine(GetWelcomeMessage());
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Enter activity duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Get ready");
        Pause();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt. You can enter as many answers as possible: ");
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
            _entries.Add(userEntry);

        }
        Console.WriteLine();
        Console.WriteLine("Well Done");
        Spinner();

        Console.WriteLine($"You entered:\n{DisplayUserEntries()}");

        Console.WriteLine(GetEndingMessage());
        Console.WriteLine("This activity lasted for "+ _duration + " seconds.");
    }

    private string GeneratePrompt()
    {
        int randomNumber = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }

     private string DisplayUserEntries()
    {
        string entries = "";
        foreach (string entry in _entries)
        {
            entries += "- " + entry + Environment.NewLine;
        }
        return entries;
    }
}


