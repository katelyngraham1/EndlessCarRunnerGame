using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallObstacle : MonoBehaviour
{
    public GameObject thePlayer;
    public AudioSource smallCrash;
    public AudioSource crash;
    public GameObject mainCam;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        if (CollectableControl.healthCount > 0)
        {
            smallCrash.Play();
            CollectableControl.healthCount -= 1;
            this.gameObject.SetActive(false);
        }
        else if (CollectableControl.healthCount == 0)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            levelControl.GetComponent<LevelDistance>().enabled = false;
            crash.Play();
            mainCam.GetComponent<Animator>().enabled = true;
            levelControl.GetComponent<EndRunSequence>().enabled = true;
        }
    }

}
