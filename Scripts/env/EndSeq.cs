using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSeq : MonoBehaviour
{
    public GameObject currentStat;
    public GameObject endStat;
    public GameObject fadeIn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndSequence());
    }

    // Update is called once per frame
   IEnumerator EndSequence()
    {

        yield return new WaitForSeconds(3);
        currentStat.SetActive(false);
        endStat.SetActive(true);
        yield return new WaitForSeconds(4);
        fadeIn.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);

    }
}
