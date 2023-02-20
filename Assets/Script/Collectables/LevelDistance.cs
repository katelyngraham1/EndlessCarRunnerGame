using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;
    public GameObject disEndDisplay;
    public GameObject levelDisplay;
    public static int disRun;
    public static bool addingDis;
    public static float disDelay = 1f;

    void Start()
    {
        disRun = 0;     //  makes sure on start up that distance is 0 again
        disDisplay.GetComponent<Text>().text = "" + disRun;
    }

    void Update()
    {
        if (addingDis == false)
        {
            addingDis = true;
            StartCoroutine(AddingDis());
        }
    }


    IEnumerator AddingDis()
    {
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;     //  display current distance
        disEndDisplay.GetComponent<Text>().text = "" + disRun;
        levelDisplay.GetComponent<Text>().text = "" + PlayerMove.setObject;
        yield return new WaitForSeconds(disDelay);      
        addingDis = false;
    }
}
