using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
{
	int ScenesUnlocked;
	public Button[] buttons;

	void Start () 
	{
		ScenesUnlocked = PlayerPrefs.GetInt("ScenesUnlocked", 1);

		foreach (Button _b in buttons)
		{
			_b.interactable = false;
		}
		// for (int i = 0; i < buttons.Length; i++)
		// {
		// 	buttons[i].interactable = false;
		// }
		
		for (int i = 0; i < ScenesUnlocked; i++)
		{
			buttons[i].interactable = true;
		}
    }

	public void LoadLevel(int SceneIndex)
	{
		SceneManager.LoadScene(SceneIndex);
	}
}
