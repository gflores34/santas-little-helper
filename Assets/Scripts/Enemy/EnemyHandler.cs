using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHandler : MonoBehaviour
{

    Rigidbody2D rb;
    public float enemyDamage;
    public float enemyLife = 2f;
    HeartController heartController;
    KillCounter killCounter;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        heartController = FindAnyObjectByType<HeartController>();
        killCounter = FindAnyObjectByType<KillCounter>();
    }


    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            StartCoroutine(heartController.HeartHandler(enemyDamage));
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("snowball"))
        {
            Die();
            Destroy(other.gameObject);
        }

        if (other.CompareTag("candy cane"))
        {
            Die();
        }

        if (other.CompareTag("ornament"))
        {
            Die();
        }
    }

    void Die()
    {
        StartCoroutine(DieCoroutine());
    }

    IEnumerator DieCoroutine()
    {
        killCounter.addKill();
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<Renderer>().enabled = false;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(.2f);
        Destroy(rb.gameObject);
    }

}
