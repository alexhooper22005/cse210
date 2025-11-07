public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _reflectionQuestions = new List<string>();


    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts.Add(" --- Think of a time when you did something really dificult. ---");
        _prompts.Add(" --- Think of a time when you acomplished something you thought was impossible. ---");
        _prompts.Add(" --- Think of a time when you exceeded a goal you set for yourself. ---");

        _reflectionQuestions.Add("> How Did you feel when it was complete? ");
        _reflectionQuestions.Add("> What was your favorite thing about this experience? ");
        _reflectionQuestions.Add("> Would you do it again? ");
        _reflectionQuestions.Add("> How might this better you as a person? ");
        _reflectionQuestions.Add("> Can you do it again but doing it further? ");


    }
    
    
    public void DoActivity()
    {
        DoStartingMessage();

        Console.Clear();
        Console.WriteLine("Get Ready..");
        SpinnerAnimation();

        Console.WriteLine("\n\nConsider the following Prompt: ");

        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        Console.WriteLine($"\n{_prompts[index]}");

        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions" +
        "as they are related to this experience.");

        Console.Write("\nYou may begin in: ");
        Countdown4();


        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        Console.Clear();
        while (DateTime.Now < endTime)
        {   
            int question = rand.Next(_reflectionQuestions.Count);
            Console.Write($"\n{_reflectionQuestions[question]}");
            SpinnerAnimation();
            Thread.Sleep(2000);
        }
            
        
            


        //have spinning animation plus 
        DoEndingMessage();
    }
}