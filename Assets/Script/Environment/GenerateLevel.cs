using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;
    public static int sectionActive;

    void Update()
    {
        if (creatingSection == false)       // if we aren't creating section then run coroutine (method that has a time delay)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 7);        //  random selection of sections
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);     //  place the section 50 positions from the last
        zPos += 50;
        yield return new WaitForSeconds(2);     // every 2 seconds creats new section
        creatingSection = false;
    }

}
