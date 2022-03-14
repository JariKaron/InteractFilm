using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Volume Setting")]
    [SerializeField] private TMP_Text volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    [SerializeField] private float defaultVolume = .5f;

    [SerializeField] private GameObject comfirmationPrompt = null;

    [Header("Levels To Load")]
    public string _newGameLevel;
    private string levelToLoad;
    [SerializeField] private GameObject noSaveGameDialog = null;
    public AudioMixer mixer;

    private float volLoad;


    private void Start() 
    {
        firstLoadVol();
        volumeSlider.onValueChanged.AddListener((v) => 
        {
            SetSoundAndText(v);
        });
    }

    void firstLoadVol()
    {
        volLoad = PlayerPrefs.GetFloat("masterVolume");
        SetSoundAndText(volLoad);
    }

    void SetSoundAndText(float _v)
    {
        volumeSlider.value = _v;
        mixer.SetFloat("Master", setValueLog(_v));
        volumeTextValue.SetText((_v*10).ToString("0"));
        PlayerPrefs.SetFloat("masterVolume", _v);
    }

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

    public float setValueLog(float _v)
    {
        return Mathf.Log10(_v)*20;
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void VolumeApply()
    {
        StartCoroutine(ConfirmationBox());
    }

    public void ResetButton(string MenuType)
    {
        if (MenuType == "Audio")
        {
            SetSoundAndText(defaultVolume);
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
