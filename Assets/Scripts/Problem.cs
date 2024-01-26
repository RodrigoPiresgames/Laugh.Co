using System;
using System.Collections.Generic;

[Serializable]
public struct Problem
{
    public static Problem None => new Problem(ProblemType.None, 0);

    public ProblemType Type { get; }
    public int Strength;

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

