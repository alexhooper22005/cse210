using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video a = new Video("Using my new boat", "Jeremy Jones", 10);
        videos.Add(a);
        a.comments.Add(new Comment("Alex", "Nice boat!"));
        a.comments.Add(new Comment("Drew", "Looks fun!"));
        a.comments.Add(new Comment("Sam", "Where did you get it?"));
        Video b = new Video("Hiking up mount everest", "Anna Smith", 25);
        videos.Add(b);
        b.comments.Add(new Comment("John", "Wow great job!"));
        b.comments.Add(new Comment("James", "Amazing View!"));
        b.comments.Add(new Comment("Kate", "Did you train?"));
        Video c = new Video("Washing my dog", "Kyle Jankens", 15);
        videos.Add(c);
        c.comments.Add(new Comment("Nathan", "I love your dog!"));
        c.comments.Add(new Comment("Brian", "Nice set up!"));
        c.comments.Add(new Comment("Sam", "What breed is your dog?"));
        Video d = new Video("Riding my dirt bike", "John Smith", 20);
        videos.Add(d);
        d.comments.Add(new Comment("Hayden", "Nice bike!"));
        d.comments.Add(new Comment("Carl", "Looks sick!"));
        d.comments.Add(new Comment("Larry", "What year is it?"));

        foreach(Video v in videos)
        {
            Console.WriteLine(v.returnVideo());

            Console.WriteLine("Comments :");
            foreach(Comment com in v.comments)
            {
                Console.WriteLine($"{com._name}, {com._text}");
            }
        }
        
    }
}