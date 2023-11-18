



public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints) : base (goalName, goalDescription, goalPoints)
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
        writer.WriteLine($"EternalGoal: {GetName()} | {GetDescription()} | {_goalPoints}");
        
    }

    public override void RecordEvent(int index, List<Goal> goals)
    {
        //base.RecordEvent(index, goals);
        Goal selectedGoal = goals[index - 1];
        selectedGoal.AddPoints();
    }
}