using System.IO;

public class Journal
{


    public void SaveToFile(List<string> list)
    {
        //prompt user for file name
        //create file [user input].txt
        //for each fullEntry in list
        //add to end of file [user input].txt
        

        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();

        filename = filename + ".txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var item in list)
            {
                outputFile.WriteLine(item);
            }
            


        }
    }

    public List<string> LoadFromFile()
    {
        List<string> loadedEntries = new List<string>();

        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        filename = filename + ".txt";


        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);


            foreach (string line in lines)
            {
                loadedEntries.Add(line);
            }
            
        }

        else
        {
            Console.WriteLine("File does not exist. Please type existing file name. ");
        }

        return loadedEntries;
        
    }
}