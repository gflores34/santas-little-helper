using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KillCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI killCounter;
    public float killCount;
    // Start is called before the first frame update
    void Start()
    {
        killCounter.text = killCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        killCount = Mathf.RoundToInt(killCount);
        killCounter.text = killCount.ToString();
    }

    public void addKill()
    {

        killCount += .5f;
    }
}
