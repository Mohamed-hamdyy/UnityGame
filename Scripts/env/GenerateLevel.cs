using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{

    public GameObject[] section;
    public int zPosition = 70;
    public bool creatingSection = false;
    public int secNum;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {

            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }
    private IEnumerator GenerateSection()
    {
        secNum= UnityEngine.Random.Range(0,2);
        Instantiate(section[secNum], new Vector3((float)-0.1, (float)-0.9, zPosition), Quaternion.identity);
        zPosition += 51;
        yield return new WaitForSeconds(3);
        creatingSection= false;


    }
}
