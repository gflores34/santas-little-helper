using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5;
    protected Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void CharMovement(Vector3 vel)
    {
        rb.velocity = vel * speed;
    }
}
