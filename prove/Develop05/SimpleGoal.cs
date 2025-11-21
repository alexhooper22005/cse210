using System.Drawing;

public class SimpleGoal : Goal
{
    
    private int _completed;

    public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points)
    {
      
        _isCompleted = completed;
    }
    
    public override void GoalInfo()
    {
        base.GoalInfo();  

      
         
    }
    
    public override int record()
    {
         if (_isCompleted)
        {
            Console.WriteLine("Goal already completed.");
            return 0;
        }

        _isCompleted = true;
        Console.WriteLine($"\nYou earned {_points} points!");
        return _points;
    }

    public override string DisplayGoal()
    {
        string checkBox = _isCompleted ? "[X]" : "[ ]";
        return $"{checkBox} {_name} ({_description})";
    }

    public override string SaveFormat()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isCompleted}";
    }


    
    
}