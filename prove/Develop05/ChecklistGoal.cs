using System.Drawing;

public class ChecklistGoal : Goal
{
    
    private int _completed;
    private int _goalTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int completed, int goalTimes, int bonus)
    : base(name, description, points)
    {
        _completed = completed;
        _goalTimes = goalTimes;
        _bonusPoints = bonus;
       
    }
    
    public override void GoalInfo()
    {
        base.GoalInfo();  

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalTimes = int.Parse(Console.ReadLine());
        
        Console.Write("What is the bonus amount? ");
        _bonusPoints = int.Parse(Console.ReadLine());
         
    }
    
    public override int record()
    {
        _completed++;
        int earned = _points;

        Console.WriteLine($"\nYou earned {_points} points!");

        if (_completed >= _goalTimes)
        {
            _isCompleted = true;
            earned += _bonusPoints;
            Console.WriteLine($"You also earned a bonus of {_bonusPoints} points!");
        }
        return earned;   
    }

    public override string DisplayGoal()
    {
        string checkBox = _isCompleted ? "[X]" : "[ ]";
        return $"{checkBox} {_name} ({_description}) -- Currently Completed {_completed} / {_goalTimes}";
    }

    public override string SaveFormat()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_completed}|{_goalTimes}|{_bonusPoints}";
    }

    
    
}