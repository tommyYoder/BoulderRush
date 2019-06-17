using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;


public class SettingsMenu : MonoBehaviour {


    public AudioMixer volMixer;

    public AudioMixer sfxMixer;

    public Slider volSlider;
    public Slider sfxSlider;
 
   

    // Saves and gets the values of the volume slider, gets the int value of the quality value, and looks for a list of the resolution dropdown values and sets them based on the player's preference.
    void Start()
    {
        volSlider.value = PlayerPrefs.GetFloat("MVolume", -40f);
        volMixer.SetFloat("volume", PlayerPrefs.GetFloat("MVolume", -40f));

        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", -40f);
        sfxMixer.SetFloat("fx", PlayerPrefs.GetFloat("SFXVolume", -40f));
    }
  
    // Will change the value of the audio slider and set the int value to each level afterwards.
    public void ChangeVol(float volume)
    {
        PlayerPrefs.SetFloat("MVolume", volume);
        volMixer.SetFloat("volume", PlayerPrefs.GetFloat("MVolume"));

    }

    // Will change the value of the sfx audio slider and set the int value to each level afterwards.
    public void ChangeFX(float fx)
    {
        PlayerPrefs.SetFloat("SFXVolume", fx);
        sfxMixer.SetFloat("fx", PlayerPrefs.GetFloat("SFXVolume"));
    }

    // Will look to see if the player is fullscreen or not. If yes, then the toggle marker is on. If no, then the toggle marker is off.
    public void SetFullscreen(bool isFullScreen)
    {
      
        Screen.fullScreen = isFullScreen;
    }
}

