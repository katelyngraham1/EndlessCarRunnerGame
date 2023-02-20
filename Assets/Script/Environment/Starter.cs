using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public GameObject fadeIn;
    public AudioSource readyfx;
    public AudioSource gofx;
    public AudioSource startUpfx;

    // fade in and count down 
    void Start()
    {
        PlayerMove.canMove = false;     // On start up the player won't be able to move until they cross the start line
        LevelDistance.disRun = 0;
        LevelDistance.addingDis = true; // distance cant be added 
        fadeIn.SetActive(true);         
        fadeIn.GetComponent<Animator>().enabled = true;
        startUpfx.Play(); 
        StartCoroutine(CountSequence());    // executes code over multiple frames
    }

    /**
     *  3, 2, 1, Go animations
     *  player movement starts
     *  starts counting distance
     */
    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        readyfx.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        readyfx.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        readyfx.Play();
        yield return new WaitForSeconds(1);
        countDownGo.SetActive(true);
        gofx.Play();
        PlayerMove.canMove = true;
        LevelDistance.addingDis = false;
        
    }
}
