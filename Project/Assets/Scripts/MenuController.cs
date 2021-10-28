using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Volume Setting")]
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = 5.0f;

    [SerializeField] private GameObject comfirmationPrompt = null;

    [Header("Levels To Load")]
    public string _newGameLevel;
    private string levelToLoad;
    [SerializeField] private GameObject noSaveGameDialog = null;


    public static float globalVolumnForAll;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newGameLevel);
    }

    public void LoadGameDialogYes()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
            levelToLoad = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            noSaveGameDialog.SetActive(true);
        }
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volumeTextValue.text = volume.ToString("0");
        Debug.Log(PlayerPrefs.GetFloat("masterVolume"));

        globalVolumnForAll = volume;
    }

    public void VolumeApply()
    {
        globalVolumnForAll = AudioListener.volume;

        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
        Debug.Log(PlayerPrefs.GetFloat("masterVolume"));
        StartCoroutine(ConfirmationBox());
    }

    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            globalVolumnForAll = defaultVolume;

            AudioListener.volume = defaultVolume;
            volumeSlider.value = defaultVolume;
            volumeTextValue.text = defaultVolume.ToString("5");
            VolumeApply();
        }
    }

    public IEnumerator ConfirmationBox()
    {
        comfirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        comfirmationPrompt.SetActive(false);
    }
}
