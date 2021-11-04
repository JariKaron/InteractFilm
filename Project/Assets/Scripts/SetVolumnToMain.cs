using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class SetVolumnToMain : MonoBehaviour
{ 
    public AudioSource theSource;
    public VideoPlayer theVideo;

    void Start()
    {

        Debug.Log(MenuController.globalVolumnForAll);

        AudioListener.volume = MenuController.globalVolumnForAll;
        theSource.volume = MenuController.globalVolumnForAll;

        Debug.Log(PlayerPrefs.GetFloat("masterVolume"));


        theVideo.SetDirectAudioVolume(0, MenuController.globalVolumnForAll);  
        theVideo.SetDirectAudioVolume(0, PlayerPrefs.GetFloat("masterVolume")); 



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
