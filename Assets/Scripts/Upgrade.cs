using System;
using System.Collections.Generic;

[Serializable]
public struct Upgrade
{
    public static Upgrade None => new Upgrade(UpgradeType.None, "", false);

    public UpgradeType Type { get; }
    public string Description;
    public bool Unlocked;

    public Upgrade(UpgradeType type, string description, bool unlocked)
    {
        Type = type;
        Description = description;
        Unlocked = unlocked;
    }

    public override string ToString()
    {
        return $"{Type} {Unlocked}";
    }
}