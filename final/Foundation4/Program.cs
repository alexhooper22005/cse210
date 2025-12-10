using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running r = new Running(new DateOnly(2025, 12, 25), 30, 2);
        Bicycle b = new Bicycle(new DateOnly(2025, 12, 25), 20, 4, 10);
        Swimming s = new Swimming(new DateOnly(2025, 12, 25), 20, 8);

        activities.Add(r);
        activities.Add(b);
        activities.Add(s);

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
        
    }
}