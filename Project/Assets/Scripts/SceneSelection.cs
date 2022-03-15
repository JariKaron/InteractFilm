using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[System.Serializable]
public class MeangButton
{
	public Button _button;
	public int sceneID;
}



public class SceneSelection : MonoBehaviour
{
	int ScenesUnlocked;
	public MeangButton[] buttons;

	// dddddddddddddd
	[Header("debug")]
	[SerializeField] TMP_Text mainText;

	void Start () 
	{
		ScenesUnlocked = PlayerPrefs.GetInt("ScenesUnlocked", 1);
		
		// dddddddddddddd
		mainText.SetText(ScenesUnlocked.ToString());

		foreach (MeangButton _b in buttons)
		{
			_b._button.interactable = false;

			if(_b.sceneID <= ScenesUnlocked)
			{
				_b._button.interactable = true;
			}
		}
		
		// for (int i = 0; i < buttons.Length; i++)
		// {
		// 	buttons[i].interactable = false;
		// }

		// for (int i = 0; i < ScenesUnlocked; i++)
		// {
		// 	buttons[i].interactable = true;
		// }
    }

	public void LoadLevel(int SceneIndex)
	{
		SceneManager.LoadScene(SceneIndex);
	}

    public void ResetLevels()
    {
        PlayerPrefs.DeleteKey("ScenesUnlocked");
    }

}
