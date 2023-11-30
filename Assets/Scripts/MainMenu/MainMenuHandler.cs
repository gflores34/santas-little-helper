using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] GameObject startSource;
    [SerializeField] GameObject quitSource;
    [SerializeField] GameObject optionsSource;

    [SerializeField] AudioSource startAudio;
    [SerializeField] AudioSource quitAudio;
    [SerializeField] AudioSource optionsAudio;

    [SerializeField] AudioMixer mixer;

    public void Awake()
    {
        SetAudio();
        startAudio = startSource.GetComponent<AudioSource>();
        quitAudio = quitSource.GetComponent<AudioSource>();
        optionsAudio = optionsSource.GetComponent<AudioSource>();
    }

    IEnumerator SelectionSubmittedSound()
    {
        startAudio.Play();
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("Woods");
    }

    IEnumerator OptionsSound()
    {
        optionsAudio.Play();
        yield return null;
        SceneManager.LoadScene("OptionsMenu");
    }

    IEnumerator QuttingSound()
    {
        quitAudio.Play();
        yield return new WaitForSeconds(.7f);
        Application.Quit();
    }

    public void PlayGame()
    {
        StartCoroutine(SelectionSubmittedSound());
    }

    public void LoadOptions()
    {
        StartCoroutine(OptionsSound());
    }

    public void QuitGame()
    {
        StartCoroutine(QuttingSound());
    }

    void SetAudio()
    {

        float masterNum = PlayerPrefs.GetFloat("master", -20);
        float musicNum = PlayerPrefs.GetFloat("music", -20);
        float sfxNum = PlayerPrefs.GetFloat("sfx", -20);

        mixer.SetFloat("master", masterNum);
        PlayerPrefs.SetFloat("master", masterNum);

        mixer.SetFloat("music", musicNum);
        PlayerPrefs.SetFloat("music", musicNum);

        mixer.SetFloat("sfx", sfxNum);
        PlayerPrefs.SetFloat("sfx", sfxNum);

        PlayerPrefs.Save();



    }

}
