using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    private float elapsedTime;
    private bool timerOn;
    private TimeSpan timer;

    private void Awake()
    {
        timerText.text = "00:00";
        StartTimer();
    }

    public void StartTimer()
    {
        timerOn = true;
        elapsedTime = 0f;

        StartCoroutine(TimerCoroutine());
    }

    public void StopTimer()
    {
        timerOn = false;
    }

    public IEnumerator TimerCoroutine()
    {
        while (timerOn)
        {
            elapsedTime += Time.deltaTime;
            timer = TimeSpan.FromSeconds(elapsedTime);

            String text = timer.ToString("mm':'ss");
            timerText.text = text;
            //Debug.Log(timer);

            yield return null;
        }

    }

}

