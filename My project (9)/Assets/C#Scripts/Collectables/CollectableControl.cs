using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CollectableControl : MonoBehaviour
{
    public static int coinCount = 0;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Update()
    {
        coinCountDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TextMeshProUGUI>().text = "" + coinCount;
    }
}
