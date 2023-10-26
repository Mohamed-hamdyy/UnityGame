using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class collControl : MonoBehaviour
{
    // controlls the view of the collected items 

    public static int currScore=0;
    public TMP_Text s;
    public TMP_Text sEnd;
    public static int red = 0;
    public TMP_Text r;
    public static int green = 0;
    public TMP_Text g;
    public static int blue = 0;
    public TMP_Text b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       s.text = $"Score: {currScore.ToString()}";
        sEnd.text = $"Score: {currScore.ToString()}";

        r.text = red.ToString() ;
        g.text = green.ToString();
        b.text = blue.ToString ();

    }
}
