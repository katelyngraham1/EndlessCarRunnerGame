using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRunSequence : MonoBehaviour
{
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject fadeOut;
    public static float highScore = 0;

    /*
     *  If player beats high score then go to the win end sequence coroutine,
     *  if player doesnt beat the current high score then show the lose end sequence coroutine
     */
    void Start()
    {
        if (highScore >= LevelDistance.disRun)
        {
            StartCoroutine(EndLoseSequence());
        }
        else if (highScore < LevelDistance.disRun)
        {
            highScore = LevelDistance.disRun;   // save new highscore 
            StartCoroutine(EndWinSequence());

        }
    }

    IEnumerator EndLoseSequence()
    {
        yield return new WaitForSeconds(3);
        //liveDis.SetActive(false);
        //endScreen.SetActive(true);
        //yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        PlayerMove.canMove = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator EndWinSequence()
    {
        yield return new WaitForSeconds(3);
        //liveDis.SetActive(false);
        //endScreen.SetActive(true);
        //yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        PlayerMove.canMove = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
