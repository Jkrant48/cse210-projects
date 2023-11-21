




public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
    {

    }

    public override void StartingMessage()
    {
        base.StartingMessage();
    }

    public override string DisplayGoal()
    {
        string goal = base.DisplayGoal();
        return goal;
    }

    public override void SaveGoalsToFile(StreamWriter writer)
    {   
        writer.WriteLine($"SimpleGoal | {GetName()} | {GetDescription()} | {_goalPoints}");
    }

    public override void LoadGoalsFromFile(string[] data)
    {
        base.LoadGoalsFromFile(data);
    }

    public override void RecordEvent(int index, List<Goal> goals)
    {
        base.RecordEvent(index, goals);
        base.AddPoints();
    }
}