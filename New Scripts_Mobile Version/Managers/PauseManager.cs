using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour {

    public MonoBehaviour[] disableScripts;

    public GameObject pauseCanvas;
    public bool isPaused;
    public GameObject pausebutton;
    public AudioSource mainAudio;

    public GameObject loadingScreen;
    public Slider loadingBar;
    public Text percText;
    public Animator fade;
    public Animator musicFade;
    public float delay = 2.5f;


    protected virtual void ToggleScripts (bool value)
    {
        foreach (var scripts in disableScripts)
        {
            scripts.enabled = value;
        }
    }

    // If the player clicks on the pause button, then the game's pause canvas is displayed, audio is muted, and time is set to 0.
    public void PauseGame()
    { 
        pauseCanvas.SetActive(true);
        pausebutton.SetActive(false);
        mainAudio.mute = true;
        ToggleScripts(false);
        Time.timeScale = 0f;
        
    }

    // If the player clicks on the resume button, then the game's pause canvas is not displayed, audio is unmuted, and time is set back to 1.
    public void UnPauseGame()
    {
        pauseCanvas.SetActive(false);
        pausebutton.SetActive(true);
        mainAudio.mute = false;
        ToggleScripts(true);
        Time.timeScale = 1f;
    }

    public void ReturnToMenu(string newGameLevel)
    {
        StartCoroutine(LoadLevelAfterDelay(newGameLevel));
        Time.timeScale = 1f;
        ToggleScripts(false);
        GameObjectUtil.Reset();
    }

    // Allows the loading screen to be displayed and the loading screen to fade in, the audio to fade to 0, and after the wait for seconds is completed, then the game will begin to load in the background.
    IEnumerator LoadLevelAfterDelay(string newGameLevel)
    {
        loadingScreen.SetActive(true);
        fade.SetTrigger("Fader");
        musicFade.SetTrigger("Fade");
        yield return new WaitForSeconds(delay);
        AsyncOperation operation = SceneManager.LoadSceneAsync(newGameLevel);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            loadingBar.value = progress;
            percText.text = progress * 100 + "%";
            yield return null;
        }
    }

    // If player clicks on the quit button, then the game file will close ending the application.
    public void Quit()
    {
        Application.Quit();
    }
}
