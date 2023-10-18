using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{

    Rigidbody2D rb;
    private GameObject gb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gb = GetComponent<GameObject>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("snowball"))
        {
            Debug.Log("Testing snowball hit " + rb.gameObject.ToString());
            Destroy(rb.gameObject);
            Destroy(other.gameObject);
        }
    }

}
