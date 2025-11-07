public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();


    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts.Add(" --- What are some things you've done to take care of yourself this month? ---");
        _prompts.Add(" --- How have you been able to show acts of kindess this month? ---");
        _prompts.Add(" --- What is some things you did recently that you're proud of? ---");
        _prompts.Add(" --- What challenges have you faced recently, and how did you overcome them? ---");
        
    }
    
    public void DoActivity()
    {
        DoStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready..");
        SpinnerAnimation();

        Console.WriteLine("\nList as any responses you can to the following prompt: ");

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.Write($"\n{_prompts[index]}");

        Console.Write("\nYou may begin in: ");
        Countdown6();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        List<string> _userinput = new List<string>();

        Console.WriteLine();
        Console.Write("\n>");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    _userinput.Add(input);
                }

                if (DateTime.Now < endTime)
                {
                    Console.Write("> ");
                }
            }
        }
        
       
            Console.WriteLine($"You listed {_userinput.Count} items!");
        


        DoEndingMessage();
    }
}