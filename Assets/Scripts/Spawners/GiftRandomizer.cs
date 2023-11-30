using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftRandomizer : MonoBehaviour
{

    [SerializeField] GameObject propSpawnPoint;
    [SerializeField] List<GameObject> propPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        SpawnGifts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnGifts()
    {
        int num = Random.Range(0, 5);


        if (num == 3)
        {
            int rand = Random.Range(0, propPrefabs.Count);
            GameObject prop = Instantiate(propPrefabs[rand], propSpawnPoint.transform.position, Quaternion.identity);
        }
       
    }
}
