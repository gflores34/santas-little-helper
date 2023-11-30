using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    [SerializeField] GameObject snowball;
    [SerializeField] Transform snowballTransform;
    [SerializeField] bool canFire;
    [SerializeField] float timeBetweenFiring;
    private GameObject snowballClone;
    private float timer;

    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
        }
        if(Input.GetMouseButtonDown(0) && canFire)
        {
            canFire = false;
            snowballClone = Instantiate(snowball, snowballTransform.position, Quaternion.identity);
            Destroy(snowballClone, 1.0f);
        }
    }

    IEnumerator SnowballInstantiate()
    {
        snowballClone = Instantiate(snowball, snowballTransform.position, Quaternion.identity);
        yield return new WaitForSeconds(timeBetweenFiring);
        Destroy(snowballClone);
    }



}
 