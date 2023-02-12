using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplayer : MonoBehaviour
{
    [SerializeField] private LocalMultiManager manager;

    [Header("Text")] 
    [SerializeField] private TextMeshProUGUI player1HP;
    [SerializeField] private TextMeshProUGUI player2HP;
    [SerializeField] private TextMeshProUGUI player3HP;
    [SerializeField] private TextMeshProUGUI player4HP;

    public void DisplayHP()
    {
        //player1HP.text
    }
}
