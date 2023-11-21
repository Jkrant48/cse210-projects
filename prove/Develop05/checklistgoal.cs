



public class ChecklistGoal : Goal
{
    private int _numberOfTimes;
    private int _bonusPoints;
    private int _timesCompleted;
    public ChecklistGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
    {
        _numberOfTimes = 0;
        _bonusPoints = 0;
        _timesCompleted = 0;
    }

    public override void StartingMessage()
    {
        base.StartingMessage();
        Console.Write("How many times does this goal need to be accompished for a bonus point? ");
        _numberOfTimes = int.Parse(Console.ReadLine());
        Console.Write($"What is the bonus point for accomplish it {_numberOfTimes} times? ");
        _bonusPoints = int.Parse(Console.ReadLine());


    }

    public override string DisplayGoal()
    {
        string goal = $"{base.DisplayGoal()} -- Currently Completed: {_timesCompleted}/{_numberOfTimes}";
        return goal;
    }


     public override void SaveGoalsToFile(StreamWriter writer)
    {
        writer.WriteLine($"CheckListGoal | {GetName()} | {GetDescription()} | {_goalPoints} | {_numberOfTimes} | {_bonusPoints} | {_timesCompleted}");
    }

    public override void LoadGoalsFromFile(string[] data)
    {
        _goalName = data[1];
        _goalDescription = data[2];
        _goalPoints = int.Parse(data[3]);
        _numberOfTimes = int.Parse(data[4]);
        _bonusPoints = int.Parse(data[5]);
        _timesCompleted = int.Parse(data[6]);
    }

    public override void RecordEvent(int index, List<Goal> goals)
    {
        
        base.AddPoints();
        _timesCompleted++;

        if (_timesCompleted == _numberOfTimes)
        {   
            base.RecordEvent(index, goals);
            _points += _bonusPoints;
        }
    }
}