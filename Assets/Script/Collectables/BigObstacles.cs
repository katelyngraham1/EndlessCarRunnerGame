using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigObstacles : MonoBehaviour
{
    public GameObject thePlayer;
    public AudioSource crash;
    public GameObject mainCam;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.GetComponent<PlayerMove>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crash.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
