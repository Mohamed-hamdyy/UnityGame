using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchForm : MonoBehaviour
{
    public GameObject charModel;
    public Material original;
    public static bool RedForm=false;
    public static bool greenForm = false;
    public static bool blueForm = false;
    public static bool returnN=false;
    public AudioSource chgForm;
    public AudioSource invClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (returnN)
        {
            returnNatural();
            returnN = false;
        }
        Renderer renderer = charModel.GetComponentInChildren<Renderer>();

        if (renderer != null)
        {
            Material[] materials = renderer.materials;

            if (Input.GetKeyUp(KeyCode.J))
            {
                if (collControl.red == 5)
                {
                    chgForm.Play();
                    materials[0].color = Color.red;
                    greenForm = false;
                    blueForm = false;
                    RedForm = true;
                    collControl.red -= 1;
                }
                else
                {
                  invClip.Play(); 
                }

            }
            if (Input.GetKeyUp(KeyCode.K))
            {
                if (collControl.green == 5)
                {
                    chgForm.Play();
                    materials[0].color = Color.green;
                    greenForm = true;
                    blueForm = false;
                    RedForm = false;
                    collControl.green -= 1;

                }
                else
                {
                    invClip.Play();
                }


            }
            if (Input.GetKeyUp(KeyCode.L))
            {
                if (collControl.blue == 5)
                {
                    chgForm.Play();
                    materials[0].color = Color.blue;
                    blueForm = true;
                    RedForm = false;
                    greenForm = false;
                    collControl.blue -= 1;

                }
                else
                {
                    invClip.Play();
                }


            }
         
        }
    }

    public void returnNatural()
    {
        Renderer renderer = charModel.GetComponentInChildren<Renderer>();

        if (renderer != null)
        {
            Material[] materials = renderer.materials;
            materials[0].color = original.color;
            chgForm.Play();
            RedForm = false;
            blueForm = false;
            greenForm = false;


        }
    }
}
