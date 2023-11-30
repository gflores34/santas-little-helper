using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider masterAudio;
    [SerializeField] Slider musicAudio;
    [SerializeField] Slider sfxAudio;
    float masterNum;
    float sfxNum;
    float musicNum;


    // Start is called before the first frame update
    void Awake()
    {
        masterNum = PlayerPrefs.GetFloat("master", 1);
        musicNum = PlayerPrefs.GetFloat("music", 1);
        sfxNum = PlayerPrefs.GetFloat("sfx", 1);

        masterAudio.value = masterNum;
        musicAudio.value = musicNum;
        sfxAudio.value = sfxNum;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateMasterAudio()
    {
        mixer.SetFloat("master", masterAudio.value);
        PlayerPrefs.SetFloat("master", masterAudio.value);

        PlayerPrefs.Save();
    }

    public void UpdateMusicAudio()
    {
        mixer.SetFloat("music", musicAudio.value);
        PlayerPrefs.SetFloat("music", musicAudio.value);

        PlayerPrefs.Save();
    }

    public void UpdateSFXAudio()
    {
        mixer.SetFloat("sfx", sfxAudio.value);
        PlayerPrefs.SetFloat("sfx", sfxAudio.value);

        PlayerPrefs.Save();
    }

}
