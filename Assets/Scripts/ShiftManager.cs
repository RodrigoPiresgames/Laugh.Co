using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShiftManager : MonoBehaviour
{

    [SerializeField] public List<Patient> shiftPatients;
    [SerializeField] public TextMeshProUGUI patientText;
    [SerializeField] public Image patientLook;

    // Start is called before the first frame update
    void Start()
    {
        while (PacientsOnList(shiftPatients))
        {
            for (int i = 0; i < shiftPatients.Count; i++)
            {
                patientLook = shiftPatients[i].sadSprite;
                foreach (string str in shiftPatients[i].dialog)
                {
                    patientText.text += str;
                }
                shiftPatients.Remove(shiftPatients[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    

    }

    private bool PacientsOnList(List<Patient> shiftPatients)
    {
        if (shiftPatients == null)
        {
            return false;
        }
        else
            return true;
    }
/*
    private IEnumerable<string> PacientTextMaker(Patient currentPatient)
    {
        string result = "";

        foreach(string line in currentPatient.dialog)
        {
            result += line;

            yield return result;
        }
    }
*/
}
