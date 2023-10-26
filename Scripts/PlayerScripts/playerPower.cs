using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPower : MonoBehaviour
{
    public static bool greenPower = false;
    public static bool bluePower = false;
    public static bool greenPressed = false;
    public static bool bluePressed = false;
    public AudioSource powerClip;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space) & SwitchForm.RedForm & collControl.red>0)
        {
            powerClip.Play();
            collControl.red -= 1;
            for(int i = 0; i < GenerateObjects.obstacles.Count; i++) {
                DestroyImmediate(GenerateObjects.obstacles[i],true);
            
            }
            if (collControl.red == 0)
            {
                SwitchForm.returnN = true;
            }

        }
        if (Input.GetKeyUp(KeyCode.Space) & SwitchForm.greenForm &collControl.green >0 & !greenPressed )
        {
            powerClip.Play();
            collControl.green -= 1;
            greenPower = true;
            greenPressed = true;
            if (collControl.green == 0)
            {
                SwitchForm.returnN = true;
            }


        }
        if (Input.GetKeyUp(KeyCode.Space) & SwitchForm.blueForm & collControl.blue > 0 & !bluePressed )
        {
            powerClip.Play();
            collControl.blue -= 1;
            bluePower = true;
            bluePressed = true;
          



        }

    }
}