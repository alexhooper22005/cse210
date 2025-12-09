using System;

class Program
{
    static void Main(string[] args)
    {
       List<Event> events = new List<Event>();

        Address a1 = new Address("2nd West", "Rexburg", "Idaho", "United States");
        Lecture l1 = new Lecture("How to do your taxes", "At this lecture we will teach you how to better do your taxes to make sure you get money back and dont ever owe money",
        new DateTime(2025, 12, 8, 14, 30, 00), a1, "Lecture", "John Smmith", 400);
        events.Add(l1);

        Address a2 = new Address("2nd West", "Rexburg", "Idaho", "United States");
        Outdoor l2 = new Outdoor("Christmas Ward Party", "Come join us for the Christmas ward party! bring a friend!",
        new DateTime(2026, 1, 5, 13, 30, 00), a2, "Outdoor", 300);
        events.Add(l2);

        Address a3 = new Address("2nd West", "Rexburg", "Idaho", "United States");
        Reception l3 = new Reception("John and Jenny's Wedding", "Come join John and Jenny for their wedding today! Make sure to rsvp!",
        new DateTime(2026, 2, 1, 17, 30, 00), a3, "Reception", "JohnSmith@gmail.com");
        events.Add(l3);

        foreach (Event e in events)
        {
            Console.WriteLine($"{e.GetFullDetails()}\n");
        }


    }
}