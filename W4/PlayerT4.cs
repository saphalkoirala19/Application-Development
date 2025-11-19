public class Player
{
    public string playerName;
    public int level;
    public int health;

    // default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // parameterized constructor
    public Player(string name, int lvl, int hp)
    {
        playerName = name;
        level = lvl;
        health = hp;
    }
}
