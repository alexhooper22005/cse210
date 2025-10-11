using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public List<string> fullEntries = new List<string>();
    static void Main(string[] args)
    {
        Program program = new Program();
        int userInput = 0;

        

        while (userInput != 5)
        {
            //menu
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt);

                Entry entry = new Entry();
                entry._prompt = prompt;
                // entry.GetEntryText();

                

                program.fullEntries.Add(entry.GetFullEntry());
            }

            if (userInput == 2)
            {
                
                foreach (string entry in program.fullEntries)
                {
                    Console.WriteLine($"{entry} \n \n");
                }
            }

            if (userInput == 3)
            {
                Journal journal = new Journal();
                program.fullEntries = journal.LoadFromFile();

                
            }

            if (userInput == 4)
            {
                

                Journal journal = new Journal();
                journal.SaveToFile(program.fullEntries);
            }
        }


    }
}