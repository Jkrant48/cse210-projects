

public class ReflectionActivity : Activity
{
    private string _prompt;
    private string _question;
    private List<string> _prompts;

    private List<string> _questions;
    private Random _random;

    private int _questionCounter;


    public ReflectionActivity() : base ("ReflectionActivity")
    {   
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        _random = new Random();

        _prompt = GeneratePrompt();

        _question = GenerateQuestion();

        _questionCounter = 0;

    }

    public void RunReflectionActivity()
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

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        Console.WriteLine($"-----  {_prompt}  -----");
        Console.WriteLine();

        Console.WriteLine("Think on this for a while and press enter when you are ready to continue...");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);


        var key = Console.ReadKey(intercept: true).Key;
        if (key == ConsoleKey.Enter)
        {
            Console.WriteLine("Ponder on each of the following questions as relate to your experience.");
            Console.Write("You may begin in:  ");
            CountDown();
            Console.WriteLine();

            while (DateTime.Now < endTime)
            {
                Console.WriteLine($"> {_question} ");
                _question = GenerateQuestion();
            }
        }

    }

    private string GenerateQuestion()
    {
        if (_questionCounter < _questions.Count)
        {
            string generatedQuestion = _questions[_questionCounter];
            _questionCounter++;
            return generatedQuestion;
        }
        
        // Handle the case where all questions have been generated.
        return "All questions have been generated.";
    }
    
    private string GeneratePrompt()
    {
        int randomNumber = _random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomNumber];

        return randomPrompt;
    }

    //displayprompt: void
    //displayquestion: void
}