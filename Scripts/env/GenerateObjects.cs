using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateObjects : MonoBehaviour
{
    public GameObject[] objects;
    public int zPosition = 15;
    public bool creatingLine = false;
    public static GameObject randomObject1;
    public static GameObject randomObject2;
    public static GameObject randomObject3;
   // public static GameObject[] obstacles;
    public static List<GameObject> obstacles = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DeleteObst", 15, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (creatingLine == false)
        {

            creatingLine = true;
            StartCoroutine(GenerateLine());
        }
    }
    private IEnumerator GenerateLine()
    {
        randomObject1 = objects[UnityEngine.Random.Range(0, objects.Length)];
        randomObject2 = objects[UnityEngine.Random.Range(0, objects.Length)];
        if (randomObject1.CompareTag("Obst") && randomObject2.CompareTag("Obst"))
        {
            randomObject3 = objects[UnityEngine.Random.Range(1, objects.Length)];
        }
        else if (randomObject1.CompareTag("empty") && randomObject2.CompareTag("empty"))
        {
            randomObject3 = objects[UnityEngine.Random.Range(0, objects.Length - 1)];
        }
        else
        {
            randomObject3 = objects[UnityEngine.Random.Range(0, objects.Length)];
        }
        ///////creating 
        if (randomObject1.CompareTag("Obst"))
        {
            GameObject Instance= Instantiate(randomObject1, new Vector3(-3.5f, 2.2f,zPosition), transform.rotation);
            obstacles.Add(Instance);
           
        }
        else
            Instantiate(randomObject1, new Vector3(-3.5f, 3, zPosition), transform.rotation);
        /////////
        
        if (randomObject2.CompareTag("Obst"))
        {
            GameObject Instance2= Instantiate(randomObject2, new Vector3(0, 2.2f, zPosition), transform.rotation);
            obstacles.Add(Instance2);

        }
        else
            Instantiate(randomObject2, new Vector3(0, 3, zPosition), transform.rotation);
        ///////
        if (randomObject3.CompareTag("Obst"))
        {
           GameObject Instance3= Instantiate(randomObject3, new Vector3(3.5f, 2.2f, zPosition), transform.rotation);
            obstacles.Add(Instance3);

        }
        else
            Instantiate(randomObject3, new Vector3(3.5f, 3, zPosition), transform.rotation);


        zPosition += 12;
        yield return new WaitForSeconds(1);
        creatingLine = false;


    }
    private void DeleteObst()
    {
        if (obstacles.Count > 2)
        {
            obstacles.RemoveAt(0);
            obstacles.RemoveAt(1);
        }
    }
  
}
