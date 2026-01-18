public class Person
{
    public readonly string Name;
    public int Turns { get; set; }

    public int Priority { get; set; } // New 

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
        Priority = 0;
    }


    //Optional constructor
    internal Person(string name, int turns, int priority)
    {
        Name = name;
        Turns = turns;
        Priority = priority;
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}