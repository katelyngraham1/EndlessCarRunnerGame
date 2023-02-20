using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHealth : MonoBehaviour
{
    public AudioSource healthFX;
    public AudioSource fullHealthFX;

    void OnTriggerEnter(Collider other)
    {
        
        if ( CollectableControl.healthCount < 3)
        {
            healthFX.Play();
            CollectableControl.healthCount += 1;
        }
        else if ( CollectableControl.healthCount >= 3)
        {
            fullHealthFX.Play();
        }

        this.gameObject.SetActive(false);  
    }

}
