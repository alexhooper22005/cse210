public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isCompleted;
    
    public Goal( string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual void GoalInfo()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public bool IsCompleted
{
    get => _isCompleted;
    set => _isCompleted = value;
}
    public abstract string DisplayGoal();

 
    public abstract int record();
    
    public int GetPoints() => _points;
    public bool IsComplete() => _isCompleted;
    public abstract string SaveFormat();



}