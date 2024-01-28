using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable
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