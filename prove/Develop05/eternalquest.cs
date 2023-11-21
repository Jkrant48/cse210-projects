

public class EternalQuest
{
    private List<Goal> _goals;
    private int _selectedGoalIndex;

    public EternalQuest()
    {
        _goals = new List<Goal>();
        _selectedGoalIndex = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

        public void DisplayGoal()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            Console.Write(_goals[i].DisplayGoal());
            Console.WriteLine();
        }
        Console.WriteLine();
        //this function will display the goals in the list
    }

    public void DisplayForRecordEvent()
    {   
        // display the goal for the user to select which is completed
        Console.WriteLine();
        Console.WriteLine("Select a goal from below:");
        for (int i = 0; i < _goals.Count; i++)
        {
            // display only uncompleted goals
            if (!_goals[i].Iscomplete())
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
            }
        }
        Console.Write("Which goal have you completed? ");
        _selectedGoalIndex = int.Parse(Console.ReadLine());
    }

    public void RecordEvent()
    {
        //mark completed and add points
        _goals[_selectedGoalIndex - 1].RecordEvent(_selectedGoalIndex, _goals);
    }

    
    public void SaveGoalsTofile(string fileName)
    {   
        // save goals to file
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                goal.SaveGoalsToFile(writer);
            }
        }

    }

    public void LoadGoalsFromFile(string fileName)
    {   
        // load the goals from the file and add to the goals list
        _goals.Clear();
        string[] lines = File.ReadAllLines(fileName);
        foreach (var line in lines)
        {
            string[] goalData = line.Split('|');

            if (goalData.Length > 0)
            {
                Goal loadedGoal;

                switch (goalData[0].Trim())
                {
                    case "SimpleGoal":
                        loadedGoal = new SimpleGoal(goalData[1].Trim(), goalData[2].Trim(), int.Parse(goalData[3].Trim()));
                    break;
                    case "EternalGoal":
                        loadedGoal = new EternalGoal(goalData[1].Trim(), goalData[2].Trim(), int.Parse(goalData[3].Trim()));
                    break;
                    case "CheckListGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalData[1].Trim(), goalData[2].Trim(), int.Parse(goalData[3].Trim()));
                        checklistGoal.LoadGoalsFromFile(goalData);
                        loadedGoal = checklistGoal;
                        break;
                    default:
                        continue; 
                }

                _goals.Add(loadedGoal);
            
            }
        }
    }

    public void DisplayTotalPoints()
    {
        int totalPoints = 0;
        foreach (var goal in _goals)
        {
            totalPoints += goal.GetPoints();
        }
        Console.WriteLine($"Your Points so far is {totalPoints} points.");
    }
}