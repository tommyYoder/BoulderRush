using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider loadingBar;
    public Text percText;
    public Animator fade;
    public Animator musicFade;
    public float delay = 2.5f;
   


	// Use this for initialization
    // Starts the loading process to the next level.
	public void NewGameBTN (string newGameLevel)
    { 
        StartCoroutine(LoadLevelAfterDelay(newGameLevel));
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

    // Will close out the game application.
    public void QuitButton()
    {
        Application.Quit();
    }
}
