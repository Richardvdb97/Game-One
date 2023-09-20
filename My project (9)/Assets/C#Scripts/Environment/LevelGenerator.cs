using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject[] section;
    public int zpos = 50;
    public bool creatingSection = false;
    public int secNum;
    

    
    void Update()
    {
       if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(AddSection());
        } 
    }

    IEnumerator AddSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0,0,zpos), Quaternion.identity);
        zpos += 50;
        yield return new WaitForSeconds(2);
        creatingSection = false;
    }
}
