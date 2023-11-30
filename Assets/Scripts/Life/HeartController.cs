using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeartController : MonoBehaviour
{

    [SerializeField] Slider slider;
    [SerializeField] float maxHealth;
    float currentHealth;

    void Awake()
    {
        slider.value = maxHealth;
        currentHealth = maxHealth;
    }

    private void Update()
    {
        slider.value = currentHealth;
    }

    public IEnumerator HeartHandler(float damage)
    {
        yield return null;
        if (slider.value != 0)
        {
            currentHealth = currentHealth - damage;
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void AddHealth(float lifePoints)
    {

        if (maxHealth > slider.value)
        {
            if ((maxHealth - slider.value) < 10)
            {
                currentHealth = maxHealth;
            }
            else
            {
                currentHealth += lifePoints;
            }
        }
    }
}
