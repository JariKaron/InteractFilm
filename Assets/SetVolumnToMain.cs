using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SetVolumnToMain : MonoBehaviour
{ 

    void Start()
    {
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
