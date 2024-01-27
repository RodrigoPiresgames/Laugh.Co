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

    public int patientNumber = 0;

    // Start is called before the first frame update
    void Start()
    {

        SetImagePacient(shiftPatients[patientNumber]);

        foreach (string str in shiftPatients[patientNumber].dialog)
        {
            patientText.text += str;
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

    private void SetImagePacient(Patient currentPacient)
    {
        if (currentPacient.isHappy)
            patientLook.sprite = currentPacient.happySprite;
        else
            patientLook.sprite = currentPacient.sadSprite;
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
