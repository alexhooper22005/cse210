public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void DoActivity()
    {

        DoStartingMessage();
        Console.Clear();
        
        Console.WriteLine("Get Ready..");
        SpinnerAnimation();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.Write($"\n\nBreath In...");
        Countdown2();
        Console.Write("\nNow Breathe Out...");
        Countdown3();


        while (DateTime.Now < endTime)
        {
            Console.Write($"\n\nBreath In...");
            Countdown4();
            Console.Write("\nNow Breathe Out...");
            Countdown6();
        }

        DoEndingMessage();
    }
}