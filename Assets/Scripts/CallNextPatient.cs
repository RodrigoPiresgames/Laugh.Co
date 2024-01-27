using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CallNextPatient : MonoBehaviour
{
    [SerializeField] public ShiftManager sM;

    public void UpdatePatienList()
    {
        sM.patientNumber += 1;
    }
}
