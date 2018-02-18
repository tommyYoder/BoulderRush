using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    public GameObject pauseCanvas;
    public bool isPaused;
    public GameObject pausebutton;
    public AudioSource mainAudio;
    
    // If the player clicks on the pause button, then the game's pause canvas is displayed, audio is muted, and time is set to 0.
    public void PauseGame()
    { 
        pauseCanvas.SetActive(true);
        pausebutton.SetActive(false);
        mainAudio.mute = true;
        Time.timeScale = 0f;
        
    }

    // If the player clicks on the resume button, then the game's pause canvas is not displayed, audio is unmuted, and time is set back to 1.
    public void UnPauseGame()
    {
        pauseCanvas.SetActive(false);
        pausebutton.SetActive(true);
        mainAudio.mute = false;
        Time.timeScale = 1f;
    }
    
   // If player clicks on the quit button, then the game file will close ending the application.
    public void Quit()
    {
        Application.Quit();
    }
}
