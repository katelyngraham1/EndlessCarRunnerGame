using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour
{
    public GameObject F3;
    public GameObject F2;
    public GameObject F1;
    // Start is called before the first frame update
    void Start()
    {
        F3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMove.setObject == 1)
        {
            F3.SetActive(true);
            F2.SetActive(false);
            F1.SetActive(false);
        }
        else if (PlayerMove.setObject == 2)
        {
            F3.SetActive(false);
            F2.SetActive(true);
            F1.SetActive(false);
        }
        else if (PlayerMove.setObject == 3)
        {
            F3.SetActive(false);
            F2.SetActive(false);
            F1.SetActive(true);
        }

    }
}
