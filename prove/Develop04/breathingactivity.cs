
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
    private string _breatheIn;
    private string _breatheOut;

    public BreathingActivity() : base ("Breathing Activity")
    {
        _breatheIn = "Breathe In...";
        _breatheOut = "Now Breathe Out...";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
    }

    //RunBreathingActivity: void
    public void RunBreathingActivity()
    {   
        Console.WriteLine(GetWelcomeMessage());
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Enter activity duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Get Ready");
        //pause function from the activity class
        Pause();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime) 
        {
            PerformBreathingCycle(_breatheIn);
            PerformBreathingCycle(_breatheOut);
        }
        
        Console.WriteLine("Well Done!");
        Spinner();

        Console.WriteLine(GetEndingMessage());
        Console.WriteLine("This activity lasted for "+ _duration +" seconds");      
    }

    private void PerformBreathingCycle(string message)
    {
        Console.Write($"{message}");
        CountDown();
        Console.WriteLine();
        Console.WriteLine();
    }
}