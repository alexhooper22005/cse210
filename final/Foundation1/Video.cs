public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string returnVideo()
    {
        return $"\nVideo: '{_title}', it is made by {_author}, and is {_length} mintues long.";
    }

    public List<Comment> comments = new List<Comment>();

}