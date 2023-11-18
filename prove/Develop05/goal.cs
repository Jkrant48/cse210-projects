

public class Goal
{
    private string _goalName;
    private string _goalDescription;
    protected int _goalPoints;
    protected int _points;
    private bool _completed;

    public Goal(string goalName, string goalDescription, int goalPoints)
    {
        _goalDescription = goalDescription;
        _goalName = goalName;
        _goalPoints = goalPoints;
        _points = 0;
    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    public virtual void AddPoints()
    {
        _points += _goalPoints;
    }
    public int GetPoints()
    {
        return _points;
    }

    // total points to eternal quest

    public virtual void StartingMessage()
    {
        Console.Write("Enter the goal name: ");
        _goalName = Console.ReadLine();

        Console.Write("Enter the goal description: ");
        _goalDescription = Console.ReadLine();

        Console.Write("Enter the goal points: ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public virtual string DisplayGoal()
    {   
        string goal;
        if (Iscomplete())
        {
            goal = $"[X]{_goalName} ({_goalDescription})";
        }
        else
        {
            goal = $"[ ]{_goalName} ({_goalDescription})";
        }
        return goal;
    }

    public virtual void MarkCompleted()
    {
        _completed = true;
    }

    public virtual bool Iscomplete()
    {
        return _completed;
    }
    public virtual void SaveGoalsToFile(StreamWriter writer)
    {
        writer.WriteLine(_points);
        string goal = $"{_goalName} | {_goalDescription} | {_goalPoints}";
        writer.WriteLine(goal);
    }

    public virtual void LoadGoalsFromFile(string[] data)
    {
        _goalName = data[0];
        _goalDescription = data[1];
        _goalPoints = int.Parse(data[2]);
        _completed = bool.Parse(data[3]);
    }

    public virtual void RecordEvent(int index, List<Goal> goals)
    {     

        Goal selectedGoal = goals[index - 1];
        selectedGoal.MarkCompleted();
         
    }

    
}   
