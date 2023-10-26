using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public string parentName;
    // Start is called before the first frame update
    void Start()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    IEnumerator DestroyClone()
    {
       yield return new WaitForSeconds(140);
        if(parentName == "Section(Clone)" || parentName =="emptyObject(Clone)"
            || parentName=="brock(Clone)" || parentName == "RedOrb(Clone)"
            || parentName == "GreenOrb(Clone)" || parentName == "BlueOrb(Clone)")
        {
            Destroy(gameObject);
        }

    }
}
