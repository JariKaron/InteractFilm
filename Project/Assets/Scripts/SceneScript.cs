using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public void Pass()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        if(currentScene >= PlayerPrefs.GetInt("ScenesUnlocked"))
        {
            PlayerPrefs.SetInt("ScenesUnlocked", currentScene + 1);
        }
        Debug.Log("Scene " + PlayerPrefs.GetInt("ScenesUnlocked") + "UNLOCKED");
    }
    
    public void ResetLevels()
    {
        PlayerPrefs.DeleteKey("ScenesUnlocked");
    }

}
