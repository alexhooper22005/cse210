using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture();

        scripture1.Display();

        string userResponse = "";

        List<string> template = new List<string>();

        


        while (userResponse != "quit")
        {
            Console.WriteLine("Press enter to continue; type 'quit' to finish. ");
            userResponse = Console.ReadLine();

             if (userResponse == "")
            {
                //clear the console
                Console.Clear();

                
                template = scripture1.HideWords();
                Console.WriteLine(scripture1.GetReferenceText());
                Console.WriteLine(string.Join(" ", template));

                if (template.All(word => word.All(c => c == '_' || !char.IsLetterOrDigit(c))))
                {
                    
                    break;
                }

                
            }
        }
    }
}