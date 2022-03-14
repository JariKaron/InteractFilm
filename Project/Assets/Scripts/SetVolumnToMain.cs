using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class SetVolumnToMain : MonoBehaviour
{ 
    // public AudioSource theSource;
    public VideoPlayer theVideo;
    float audioVol;

    void Start()
    {
        theVideo = FindObjectOfType<VideoPlayer>();
        Debug.Log(theVideo);

        // Debug.Log(MenuController.globalVolumnForAll);

        AudioListener.volume = MenuController.globalVolumnForAll;
        // theSource.volume = MenuController.globalVolumnForAll;
        audioVol = PlayerPrefs.GetFloat("masterVolume");

        Debug.Log(PlayerPrefs.GetFloat("masterVolume"));

        // theVideo.SetDirectAudioVolume(0, MenuController.globalVolumnForAll);  
        print(audioVol);
        theVideo.SetDirectAudioVolume(0, audioVol); 



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
