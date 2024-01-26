using System.Collections.Generic;

public struct Problem
{
    public static Problem None => new Problem(ProblemType.None, 0);

    public ProblemType Type { get; }
    public int Strength { get; }

    public Problem(ProblemType type, int strength)
    {
        Type = type;
        Strength = strength;
    }

    public override string ToString()
    {
        return $"{Type} {Strength}";
    }
}

