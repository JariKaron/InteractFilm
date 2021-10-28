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
        Debug.Log("WAAAAAAA");

        theSource.volume = PlayerPrefs.GetFloat("masterVolume");

        Debug.Log("BBBBBBBBBBBBBBBB");

        if(PlayerPrefs.HasKey("masterVolume"))
        {
            AudioListener.volume = PlayerPrefs.GetFloat("masterVolume");
        }
        else
        {
            Debug.Log("Cannot find playerPref");
        }
    }




}
