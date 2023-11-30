using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PickupHandler : MonoBehaviour
{
    [SerializeField]List<GameObject> weapons = new List<GameObject>();
    List<GameObject> usedWeapons = new List<GameObject>();
    [SerializeField] TextMeshProUGUI pickupAlertText;

    [SerializeField] float lifePoints;
    HeartController heartController;

    void Awake()
    {
        for(int i = 0; i < weapons.Count; i++)
        {
            weapons[i].SetActive(false);
        }

        heartController = FindAnyObjectByType<HeartController>();
        pickupAlertText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        GameObject pickup = other.gameObject;


        if (other.CompareTag("gift")){
            
            int weaponNum = Random.Range(0, weapons.Count);

            if (weapons[weaponNum].activeSelf == true)
            {
                weaponNum = Random.Range(0, weapons.Count);
            }

            if (usedWeapons.Count == weapons.Count)
            {
                heartController.AddHealth(lifePoints);
                StartCoroutine(Pickup(pickup, "+10 health"));
            }


            if (weapons[weaponNum].activeSelf == false)
            {
                weapons[weaponNum].SetActive(true);
                usedWeapons.Add(weapons[weaponNum]);
                StartCoroutine(Pickup(pickup, weapons[weaponNum].tag));
            }

            
        }
    }
    

    IEnumerator Pickup(GameObject pickup, string pickupText)
    {
        pickupAlertText.text = pickupText;
        pickupAlertText.enabled = true;

        pickup.GetComponent<BoxCollider2D>().enabled = false;
        pickup.GetComponent<Renderer>().enabled = false;
        
        pickup.GetComponent<AudioSource>().Play();

        yield return new WaitForSeconds(.5f);

        Destroy(pickup);

        yield return new WaitForSeconds(2f);

        pickupAlertText.enabled = false;
    }

}
