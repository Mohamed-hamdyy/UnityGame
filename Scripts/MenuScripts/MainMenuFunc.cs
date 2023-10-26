using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject MenuButtons;
    public GameObject OptionsPage;
    public Toggle muteToggle;
    // Start is called before the first frame update
    void Start()
    {
        muteToggle.isOn = false;
      

        // Add a listener to the toggle's value change event
        muteToggle.onValueChanged.AddListener(OnToggleValueChanged);
        OnToggleValueChanged(muteToggle.isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(1);  
    }
    public void options()
    {
        MenuButtons.SetActive(false);
        OptionsPage.SetActive(true);


    }
    public void reverseOpt()
    {
        MenuButtons.SetActive(true);
        OptionsPage.SetActive(false);


    }
    void OnToggleValueChanged(bool isMuted)
    {
        // Mute or unmute all audio sources in the scene
        AudioListener.pause = isMuted;

   
    }
    public void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif

    }


}
