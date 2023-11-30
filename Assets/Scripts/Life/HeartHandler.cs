using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartHandler : MonoBehaviour
{
    HeartController heartController;
    [SerializeField] float enemyDamage;
    // Start is called before the first frame update
    void Awake()
    {
        heartController = FindAnyObjectByType<HeartController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("snowman"))
        {
            StartCoroutine(heartController.HeartHandler(enemyDamage));
        }
    }
}
