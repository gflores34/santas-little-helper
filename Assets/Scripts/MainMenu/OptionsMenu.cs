using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenuHandler : MonoBehaviour
{
    [SerializeField] GameObject backSource;

    [SerializeField] AudioSource backAudio;
    [SerializeField] Slider brightnessSlider;
    [SerializeField] Dropdown resolutionDropdown;
    Resolution[] resolutions;
    public void Awake()
    {
        backAudio = backSource.GetComponent<AudioSource>();
        SetDropDown();
    }

    void SetDropDown()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
    
            options.Add(option);
            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void Vsync(bool toggle)
    {
        if (toggle == true)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }

    public void SetBrightness()
    {
        float brightnessValue = brightnessSlider.value;
        Screen.brightness = brightnessValue;
    }

    IEnumerator BackToMain()
    {
        backAudio.Play();
        SceneManager.LoadScene("MainMenu");
        yield return null;
    }

    public void LoadMainMenu()
    {
        StartCoroutine(BackToMain());
    }

}
