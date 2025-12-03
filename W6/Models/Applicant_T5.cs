namespace W6.Models;

public class Applicant
{
    public string Name { get; }
    public int Age { get; }

    public Applicant(string name, int age)
        => (Name, Age) = (name, age);
}
