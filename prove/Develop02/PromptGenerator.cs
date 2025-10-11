
public class PromptGenerator
{
    private List<String> _prompts = new List<String>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);

        string randpromt = _prompts[index];

        return randpromt;
    }
    


    

}