using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Audio;

public class SetVolumnToMain : MonoBehaviour
{ 
    [SerializeField] AudioMixer mixer;
    float audioVol;

    void Start()
    {
        audioVol = PlayerPrefs.GetFloat("masterVolume");
        mixer.SetFloat("Master", Mathf.Log10(audioVol)*20);
    }


}
