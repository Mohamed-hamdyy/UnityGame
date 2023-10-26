using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class countStarter : MonoBehaviour
{

    public GameObject countThree;
    public GameObject countTwo;
    public GameObject countOne;
    public GameObject countGo;
    public GameObject fade;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CountSeq());
    }
    IEnumerator CountSeq()
    {

        yield return new WaitForSeconds(1.5f);
        countThree.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countTwo.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countOne.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countGo.SetActive(true);
        PlayerMove.canMove = true;

    }
}
