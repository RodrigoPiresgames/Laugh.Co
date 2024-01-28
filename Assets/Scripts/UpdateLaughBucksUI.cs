using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateLaughBucksUI : MonoBehaviour
{
    [SerializeField] public PlayerMoney pM;
    [SerializeField] public TextMeshProUGUI display;

    void Update()
    {
        display.text = pM.money.ToString();
    }
}
