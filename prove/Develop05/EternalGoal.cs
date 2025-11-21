using System.Drawing;

public class EternalGoal : Goal
{
    
    private int _completed;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
      

    }
    
    public override void GoalInfo()
    {
        base.GoalInfo();  // call parent version first

      
         
    }
    
    public override int record()
    {
        Console.WriteLine($"\nYou earned {_points} points!");
        return _points;
    }

    public override string DisplayGoal()
    {
        
        return $"[ ] {_name} ({_description})";
    }

    public override string SaveFormat()
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }


    
    
}