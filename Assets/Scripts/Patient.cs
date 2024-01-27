using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Patient", menuName = "ScriptableObjects/CreatePatient")]
public class Patient : ScriptableObject
{

    public int money;
    public bool isHappy;
    public string[] dialog;
    public Problem[] problems = new Problem[5];
    public Sprite sadSprite;
    public Sprite happySprite;

    // Start is called before the first frame update

    bool TryReduceProblem(ProblemType type, int amount)
    {
        if (problems[(int)type].Strength > 0)
        {
            Mathf.Clamp(problems[(int)type].Strength -= amount, 0, 100);
            return true;
        }

        return false;
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}