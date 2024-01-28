using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Upgrade", menuName = "ScriptableObjects/CreateUpgrade")]
[Serializable]
public class Upgrade : ScriptableObject
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