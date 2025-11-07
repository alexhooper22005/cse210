public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        
    }

    public void DoStartingMessage()
    {
        Console.WriteLine($"\n\nWelcome to the {_name} Activity");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        

    }

    public void DoEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name} Activity.");
    }


    protected void SpinnerAnimation()
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach (string s in animation)
        {
            Console.CursorVisible = false;
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.CursorVisible = true;
        }
    }

    protected void Countdown6()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.CursorVisible = false;
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.CursorVisible = true;
        }
    }
    protected void Countdown4()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.CursorVisible = false;
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.CursorVisible = true;
        }
    }
    protected void Countdown3()
    {
      for (int i = 3; i > 0; i--)
        {
            Console.CursorVisible = false;
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.CursorVisible = true;
        }
    }
    protected void Countdown2()
    {
        for (int i = 2; i > 0; i--)
        {
            Console.CursorVisible = false;
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.CursorVisible = true;
        }
    }
}