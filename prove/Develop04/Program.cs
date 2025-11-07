using System;

class Program
{
    static void Main(string[] args)
    {

        


        int userInput = 0;

            while (userInput != 4)
        {
            //menu
            
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                BreathingActivity a = new BreathingActivity("Breathing", "This activity will help you relax by walking you" +
                "through breathing in and out slowly. Clear your mind and focus your breathing." , 10);
                a.DoActivity();
            }

            if (userInput == 2)
            {
                ReflectingActivity r = new ReflectingActivity("Reflecting", "This activity will help you reflect on" +
                "times in your life when you have shown strength and resilience. This will help yourecognize the power" +
                "you have and how you can use it in other aspects of your life.", 10);
                r.DoActivity();
            }

            if (userInput == 3)
            {
                ListingActivity l = new ListingActivity("Listing", "This activity will help you reflect on the good things" +
                "in your life by having you list as many things as you can in a certain area", 10);
                l.DoActivity();
            }

            if (userInput == 4)
            {
                break;
            }
            if (userInput >= 5 || userInput < 1 )
            {
                Console.WriteLine("\nPlease select a valid option. \n");
            }
        }


    }
}
