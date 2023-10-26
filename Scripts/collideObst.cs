using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collideObst : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject charModel;
    public AudioSource audioCrash;
    public AudioSource crashClip;
    public GameObject levelControl;



    void OnTriggerEnter(Collider other)
    {
        if ((SwitchForm.blueForm || SwitchForm.RedForm || SwitchForm.greenForm) & other.CompareTag("Obst") & !playerPower.bluePower)
        {
            crashClip.Play();
            Destroy(other.gameObject);
            SwitchForm.returnN = true;
        }
        else if ((SwitchForm.blueForm || SwitchForm.RedForm || SwitchForm.greenForm) & other.CompareTag("Obst") & playerPower.bluePower)
        {
            crashClip.Play();
            Destroy(other.gameObject);
            playerPower.bluePower = false;
            playerPower.bluePressed = false;
            if (collControl.blue == 0)
            {
                SwitchForm.returnN = true;
            }
        }
        else {
            if (other.CompareTag("Obst"))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                this.GetComponent<PlayerMove>().enabled = false;
                charModel.GetComponent<Animator>().Play("fall back");
                this.transform.Translate(new Vector3(-1, -2.5f, 6));
                audioCrash.Play();
                levelControl.GetComponent<EndSeq>().enabled = true;
            }
        }
    }
}

