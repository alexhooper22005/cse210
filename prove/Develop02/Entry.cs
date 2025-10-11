
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _text { get; set; }

    public DateTime _date;

    public string _prompt { get; set; }
    
    
    


    // GetEntryText will return users input for journal entry
    public string GetEntryText()
    {
        Console.Write(">");
        string entryText = Console.ReadLine();

        return entryText;
    }


    public string GetEntryDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }

    // GetFullEntry will combine the prompt date and entry text
    public string GetFullEntry()
    {
        string text = GetEntryText();
        string date = GetEntryDate();


        return $"Date {date} - Prompt: {_prompt} \n {text}";
    }
}