using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LocalMultiScoresDisplayer : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> listPlayerScoresTexts;

    public void DisplayPoints(LocalMultiManager manager)
    {
        for (int i = 0; i < listPlayerScoresTexts.Count; i++)
        {
            listPlayerScoresTexts[i].text = manager.localPlayer[i]._name + " " + manager.localPlayer[i].points;
        }
    }
}
