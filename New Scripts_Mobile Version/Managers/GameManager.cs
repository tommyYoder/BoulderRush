using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour {

    public GameObject playerPrefab;
    public Text continueText;
    public Text scoreText;
    public AudioSource mainTheme;
    public AudioSource clickSound;
    public AudioSource gameOver;

    private float timeElasped = 0f;
    private float bestTime = 0f;

    public TimeManager timeManager;
    private float blinkTime = 0f;
    private bool blink;
    private bool gameStarted;

    private GameObject player;

    public GameObject floor;
    public Spawner spawner;
    private bool bestBestTime;

    public TimerScore timerscore;

    public GameObject pauseButton;

    // Gets and finds components before the game is started.
     void Awake()
    {
        mainTheme.Stop();
        pauseButton.SetActive(false);
    }

    // Use this for 
    // Sets the floor's position to the height of the pixel perfect camera script, makes the spawner false, and sets the timer and score text components.
    void Start () {
        var floorHeight = floor.transform.localScale.y;

        var pos = floor.transform.position;
        pos.x = 0;
        pos.y = -((Screen.height / PixelPerfectCamera.pixelesToUnits) / 2) + (floorHeight / 2);
        floor.transform.position = pos;

        spawner.active = false;
        Time.timeScale = 0;
        continueText.text = "PRESS THE SCREEN TO START!";
       
        bestTime = PlayerPrefs.GetFloat("BestTime");
	}
	
	// Update is called once per frame
    // Once any key is pressed, then the game will begin.
	void Update () {
		if(!gameStarted && Time.timeScale == 0)
        {
            if (Input.anyKeyDown)
            {
                timeManager.ManipulateTime(1, 1f);
                ResetGame();
                mainTheme.Play();
                clickSound.Play();
                pauseButton.SetActive(true);
            }
        }
        // Before the game is started the text will blink. If the player bests their high score, then the text will display yellow. If not higher than previous score, then the text will display white.
        if (!gameStarted)
        {
            blinkTime++;

            if (blinkTime % 40 == 0)
            {
                blink = !blink;
            }
            continueText.canvasRenderer.SetAlpha(blink ? 0 : 1);

            var textColor = bestBestTime ? "#FF0" : "#FFF";

            scoreText.text = "TIME: " + FormatTime(timeElasped)+"\n<color="+textColor+">BEST: " + FormatTime(bestTime)+"</color>";

        }else
        {
            timeElasped += Time.deltaTime;
            scoreText.text = "TIME: " + FormatTime(timeElasped);

            if(timeElasped <= 0)
            {
                spawner.delayRange = new Vector2(5, 6);
            }
            if (timeElasped >= 15)
            {
                TimerScore.TimerCount = 15;
            }
            if (timeElasped >= 60)
            {
                TimerScore.TimerCount1 = 60;
                spawner.delayRange = new Vector2(4, 5);
            }
            if (timeElasped >= 120)
            {
                TimerScore.TimerCount2 = 120;
                spawner.delayRange = new Vector2(3, 4);
            }
            if (timeElasped >= 180)
            {
                TimerScore.TimerCount3 = 180;
                spawner.delayRange = new Vector2(2, 3);
            }
            if (timeElasped >= 240)
            {
                TimerScore.TimerCount4 = 240;
                spawner.delayRange = new Vector2(1, 2);
            }
            if (timeElasped >= 300)
            {
                TimerScore.TimerCount5 = 300;
            }
            if (timeElasped >= 360)
            {
                TimerScore.TimerCount6 = 360;
            }
            if (timeElasped >= 420)
            {
                TimerScore.TimerCount7 = 420;
            }
            if (timeElasped >= 480)
            {
                TimerScore.TimerCount8 = 480;
                spawner.delayRange = new Vector2(.5f, 1.5f);
            }
            if (timeElasped >= 540)
            {
                TimerScore.TimerCount9 = 540;
            }
            if (timeElasped >= 600)
            {
                TimerScore.TimerCount10 = 600;
            }
        }
    }

    // Once the player is killed, then the spawner is set to false, the DestroyOffScreen script is set to true, the player's rigidbody is set to zero, the timer gets set to 0 within 5.5 seconds, 
    // the text is set to inform player, main sound is set to false plus muted, and player's score is displayed.
    void OnPlayerKilled()
    {
        spawner.active = false;
        var playerDestroyScript = player.GetComponent<DestroyOffScreen>();
        playerDestroyScript.DestroyCallBack -= OnPlayerKilled;

        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        timeManager.ManipulateTime(0, 5.5f);
        gameStarted = false;
        pauseButton.SetActive(false);


        continueText.text = "PRESS THE SCREEN TO RESTART!";
        gameOver.Play();
        mainTheme.mute = true;
        mainTheme.loop = true;

        if (timeElasped > bestTime)
        {
            bestTime = timeElasped;
            PlayerPrefs.SetFloat("BestTime", bestTime);
            bestBestTime = true;
           
        }
    }

    // Once the player hits any button, then the spawner is set to true, the player is set to the top of the screen, looks to allow the DestroyOffScreen to be true when the player goes off screen,
    // Sets the text's alpha to 0, sets best time to false, and unmutes the audio to allow the main audio to play.
    void ResetGame()
    {
        spawner.active = true;
        pauseButton.SetActive(true);

        player = GameObjectUtil.Instantiate(playerPrefab, new Vector3(0, (Screen.height / PixelPerfectCamera.pixelesToUnits) / 2 + 100, 0));

        var playerDestroyScript = player.GetComponent<DestroyOffScreen>();
        playerDestroyScript.DestroyCallBack += OnPlayerKilled;
        gameStarted = true;

        continueText.canvasRenderer.SetAlpha(0);
        timeElasped = 0;
        bestBestTime = false;
        
        mainTheme.mute = false;
        mainTheme.loop = true;
    }

    public void TimerAmount()
    {
        if (timeElasped >= 15)
        {
            TimerScore.TimerCount = 15;
        }
        if(timeElasped >= 60)
        {
            TimerScore.TimerCount1 = 60;
            spawner.delayRange = new Vector2(4, 5);
        }
        if(timeElasped >= 120)
        {
            TimerScore.TimerCount2 = 120;
            spawner.delayRange = new Vector2(3, 4);
        }
        if(timeElasped >= 180)
        {
            TimerScore.TimerCount3 = 180;
            spawner.delayRange = new Vector2(2, 3);
        }
        if(timeElasped >= 240)
        {
            TimerScore.TimerCount4 = 240;
            spawner.delayRange = new Vector2(1, 2);
        }
        if(timeElasped >= 300)
        {
            TimerScore.TimerCount5 = 300;
        }
    }

    // Sets the timer to display in minutes and seconds.
    string FormatTime(float value)
    {
        TimeSpan t = TimeSpan.FromSeconds(value);


        return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
    }
}
