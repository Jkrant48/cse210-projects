

public class Activity
{
    private string _welcomeMessage;
    private string _endingMessage;
    protected int _duration{get; set;}
    protected string _description;
    private string _activityName;
    private List<string> _spinnerStrings;

    public Activity(string activity){

        _activityName = activity;

        _welcomeMessage = $"Welcome to the {_activityName}.";

        _endingMessage = $"Congratulations, you have successfully completed {_duration} of the {_activityName}";

        _spinnerStrings = new List<string>
        {
            "|","/","-","\\","|","/","-","\\"
        };
    }

    public string GetWelcomeMessage()
    {
        return _welcomeMessage;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void Pause()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner()
    {
        foreach (string s in _spinnerStrings)
        {
            Console.Write(s);
            Thread.Sleep(900);
            Console.Write("\b \b");
        }
    }
    
    
}