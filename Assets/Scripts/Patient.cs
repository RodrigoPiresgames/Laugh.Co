using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Patient", menuName = "ScriptableObjects/CreatePatient")]
public class Patient : ScriptableObject
{

    public int money;
    public Problem[] problems = new Problem[5];

    //Trying to find a way to display all the problems a patient has and their strength
    //public Problem[] problems;

    public Sprite sadSprite;
    public Sprite happySprite;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}