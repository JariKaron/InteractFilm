using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QT_Event : MonoBehaviour
{
    public float fillAmount = 0;
    public float timeThreshold = 0;
    public string eventSucess = "n";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            // Debug.Log("press");
            fillAmount += .2f;
        }
        timeThreshold += Time.deltaTime;

        if (timeThreshold>.1)
        {
            timeThreshold = 0;
            fillAmount -= .02f;
        }

        if (fillAmount<0)
        {
            fillAmount = 0;
        }

        if (fillAmount>1)
        {
            eventSucess = "y";
            Debug.Log(eventSucess);
            // SceneChage
            SceneManager.LoadScene(1);
        }
        
        GetComponent<Image>().fillAmount = fillAmount;
    }
}
