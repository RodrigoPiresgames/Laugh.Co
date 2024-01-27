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
    [SerializeField] public RectTransform patientLeft;

    public int patientNumber = 0;
    public float maxPatients;

    // Start is called before the first frame update
    void Start()
    {
        maxPatients = shiftPatients.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (PacientsOnList(shiftPatients))
        {
            SetUpNewPatient(shiftPatients[patientNumber]);
            UpdateShiftDisplay(maxPatients);
        }
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

    private void SetImagePacient(Patient currentPatient)
    {
        if (currentPatient.isHappy)
            patientLook.sprite = currentPatient.happySprite;
        else
            patientLook.sprite = currentPatient.sadSprite;
    }

    private void SetUpNewPatient(Patient currentPatient)
    {
        SetImagePacient(shiftPatients[patientNumber]);

        patientText.text = " ";

        foreach (string str in shiftPatients[patientNumber].dialog)
        {
            patientText.text += str;
        }
    }

    private void UpdateShiftDisplay(float maxPatients)
    {
        Vector3 v3 = patientLeft.localScale;
        v3.y = shiftPatients.Count / maxPatients;
        patientLeft.localScale = v3;
    }

}
