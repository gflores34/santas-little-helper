using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pauseText;
    [SerializeField] Button backButton;
    // Start is called before the first frame update
    void Awake()
    {
        pauseText.enabled = false;
        backButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        InputManagement();
    }

    void InputManagement()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseText.enabled = false;
                backButton.gameObject.SetActive(false);
            }
            else if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseText.enabled = true;
                backButton.gameObject.SetActive(true);
            }
        }
    }
}
