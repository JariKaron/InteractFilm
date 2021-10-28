using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class SetVolumnToMain : MonoBehaviour
{ 
    public AudioSource theSource;

    void Start()
    {

        AudioListener.volume = MenuController.globalVolumnForAll;
        theSource.volume = MenuController.globalVolumnForAll;

        if(PlayerPrefs.HasKey("masterVolume"))
        {
            AudioListener.volume = MenuController.globalVolumnForAll;

            AudioListener.volume = PlayerPrefs.GetFloat("masterVolume");
        }
        else
        {
            Debug.Log("Cannot find playerPref");
        }
    }




}
