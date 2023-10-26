using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{

    public GameObject pausestat;
    private bool isGamePaused = false;

    public AudioSource mainClip;
    public AudioSource pauseclip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            isGamePaused = !isGamePaused;

            if (isGamePaused)
            {
                pauseclip.Play();
                mainClip.Pause();
                // Pause the game by setting the time scale to 0
                Time.timeScale = 0f;
            }
            else
            {
                pauseclip.Pause();
                mainClip.Play();
                // Resume the game by setting the time scale back to 1
                Time.timeScale = 1f;
            }
        }
        pausestat.SetActive(isGamePaused);
    }


    public void mainMenu()
    {
        Time.timeScale = 1f;
        isGamePaused = !isGamePaused;
        SceneManager.LoadScene(0);

    }
    public void restart()
    {
        Time.timeScale = 1f;
        isGamePaused = !isGamePaused;
        SceneManager.LoadScene(1);
    }
    public void mainMenuOver()
    {
      
        SceneManager.LoadScene(0);

    }
    public void restartOver()
    {
     
        SceneManager.LoadScene(1);
    }


}
