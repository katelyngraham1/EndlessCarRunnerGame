using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    public static int healthCount;
    public GameObject healthCountDisplay;

    private void Start()
    {
        healthCount = 0;
    }

    void Update()
    {
        healthCountDisplay.GetComponent<Text>().text = "" + healthCount + "/ 3";
    }
}
