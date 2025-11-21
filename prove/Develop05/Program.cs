using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        int totalPoints = 0;

        Console.Clear();
        bool running = true;
        while (running)
        {

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bool run = true;
                    while (run)
                    {

                        Console.WriteLine("\nThe types of Goals are:");
                        Console.WriteLine("   1. Simple Goal");
                        Console.WriteLine("   2. Eternal Goal");
                        Console.WriteLine("   3. Checklist Goal");
                        Console.Write("\nEnter your choice: ");

                        string goalChoice = Console.ReadLine();

                        switch (goalChoice)
                        {
                            case "1":
                                SimpleGoal sg = new SimpleGoal("", "", 0, false);
                                sg.GoalInfo();
                                goals.Add(sg);
                                run = false;
                                break;

                            case "2":
                                EternalGoal eg = new EternalGoal("", "", 0);
                                eg.GoalInfo();
                                goals.Add(eg);
                                run = false;   
                                break;

                            case "3":
                                ChecklistGoal cg = new ChecklistGoal("", "", 0, 0, 0, 0);
                                cg.GoalInfo();
                                goals.Add(cg);
                                run = false;
                                break;

                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                run = false;
                                break;
                        }
                    }
                    break;

                case "2":
                    Console.WriteLine("\nYour Goals:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].DisplayGoal()}");
                    }
                    break;

                case "3":
                    
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();

                    filename = filename + ".txt";
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (var goal in goals)
                        {
                            outputFile.WriteLine(goal.SaveFormat());
                        }
                    }
                    break;

                case "4":
                   

                    Console.Write("What is the filename? ");
                    filename = Console.ReadLine();
                    filename = filename + ".txt";


                    if (File.Exists(filename))
                    {
                        string[] lines = File.ReadAllLines(filename);

                        foreach (string line in lines)
                        {
                            string[] parts = line.Split("|");
                            string type = parts[0];

                            if (type == "Simple")
                            {
                                goals.Add(new SimpleGoal(
                                    parts[1], parts[2], int.Parse(parts[3]),
                                    bool.Parse(parts[4])
                                ));
                            }

                            else if (type == "Eternal")
                            {
                                goals.Add(new EternalGoal(
                                    parts[1], parts[2], int.Parse(parts[3])
                                ));
                            }

                            else if (type == "Checklist")
                            {
                                goals.Add(new ChecklistGoal(
                                    parts[1], parts[2], int.Parse(parts[3]),
                                    int.Parse(parts[4]), // completed
                                    int.Parse(parts[5]), // goalTimes
                                    int.Parse(parts[6])  // bonusPoints
                                ));
                            }
                        }

                            
                    }

                    else
                    {
                        Console.WriteLine("File does not exist. Please type existing file name. ");
                    }

                    

                    break;
                case "5":
                    Console.WriteLine("\nWhich goal did you accomplish?");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goals[i].DisplayGoal()}");
                    }

                    Console.Write("\nEnter the number: ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    goals[index].record();  

                    
                    totalPoints += goals[index].GetPoints();

                    Console.WriteLine($"You now have {totalPoints} points.");
                    break;
                    
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}