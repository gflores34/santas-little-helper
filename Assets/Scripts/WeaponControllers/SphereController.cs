using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float degreesPerSecond;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(player.transform.position, Vector3.forward, degreesPerSecond *  Time.deltaTime);
    }
}
