using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed;     // Controls player speed
    public float leftRightSpeed = 4;    // controls how fast player can move left or right
    public static bool canMove = false;
    public static int setObject = 1;
    public AudioSource BGM1;
    public AudioSource BGM2;
    public AudioSource BGM3;

    void Update()    
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        /*
         * Level control, 
         * F3 - less obstacles, more health in game. player speed of 7.5, background music 1 playing
         * F2 - increase in obstacles, decrease in health displayed in game. player speed of 11.25 forward and 6f left right movement, baclground music 2 playing.
         * F1 - most possible obstacles displayed, little health available. player speed of 16 forward and 8 left right movement, background music 3 playing.
         */
        if (LevelDistance.disRun > 1 && LevelDistance.disRun < 100)
        {
            setObject = 1;
            BGM1.Play();
            moveSpeed = 7.5f;
            leftRightSpeed = 4f;
        }
        else if (LevelDistance.disRun >= 100 && LevelDistance.disRun < 250)
        {
            setObject = 2;
            BGM2.Play();
            moveSpeed = 11.25f;
            leftRightSpeed = 6f;
        }
        else if (LevelDistance.disRun >= 250)
        {
            setObject = 3;
            BGM3.Play();
            moveSpeed = 16f;
            leftRightSpeed = 8f;
        }


        if (canMove == true) 
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))     // Allows both left arrow and a keys to move player left
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)   // check if x position if greater that level boundary
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }

            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))     // Allows both right arrow and a keys to move player right
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)     // check if x position is less than the level boundary
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);   // move negative 1 left (actually moves right)
                }
            }
        }

    }
}
