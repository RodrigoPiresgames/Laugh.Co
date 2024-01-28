using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Treatment", menuName = "ScriptableObjects/CreateTreatment")]
public class Consumable: ScriptableObject
{
    public ProblemType[] TreatableTypes;
    public int ConsumableStrength;
    public string ConsumableName;
    
    public Consumable(ProblemType[] treatableTypes, int consumableStrength, string consumableName)
    {
        TreatableTypes = treatableTypes;
        ConsumableStrength = consumableStrength;
        ConsumableName = consumableName;
    }
}