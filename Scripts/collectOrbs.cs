using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectOrbs : MonoBehaviour
{

    public AudioSource orbColl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Obst"))
        {
            if (playerPower.greenPower)
            {
                if (other.CompareTag("redOrb") == true)
                {

                    collControl.currScore += 5;
                    collControl.red += 2;
                    if (collControl.red > 5)
                        collControl.red = 5;


                }
                if (other.CompareTag("blueOrb") == true)
                {

                    collControl.currScore += 5;
                    collControl.blue += 2;
                    if (collControl.blue > 5)
                        collControl.blue = 5;


                }
                else
                {
                    collControl.currScore += 10;


                }


                orbColl.Play();
                other.gameObject.SetActive(false);
                playerPower.greenPower = false;
                playerPower.greenPressed = false;
            }
            else
            {
                if (other.CompareTag("greenOrb") == true)
                {
                    if (SwitchForm.greenForm)
                    {
                        collControl.currScore += 2;
                    }
                    else
                    {
                        collControl.currScore += 1;

                        if (collControl.green < 5)
                        {
                            collControl.green += 1;

                        }
                    }
                }
                else if (other.CompareTag("redOrb") == true)
                {
                    if (SwitchForm.RedForm)
                    {
                        collControl.currScore += 2;
                    }
                    else
                    {
                        collControl.currScore += 1;

                        if (collControl.red < 5)
                        {
                            collControl.red += 1;

                        }
                    }
                }

                else
                {
                    if (SwitchForm.blueForm)
                    {
                        collControl.currScore += 2;
                    }
                    else
                    {
                        collControl.currScore += 1;

                        if (collControl.blue < 5)
                        {
                            collControl.blue += 1;

                        }
                    }
                }

                orbColl.Play();
                other.gameObject.SetActive(false);

            }
        }
    }
}

