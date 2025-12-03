namespace W6.Models;

public class Song
{
    public string Title { get; }
    public int Duration { get; } // seconds

    public Song(string title, int duration)
        => (Title, Duration) = (title, duration);
}
