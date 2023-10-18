using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSkeletonSpawner : MonoBehaviour
{

    [SerializeField] GameObject SkeletonPrefab;
    [SerializeField] GameObject newSkeleton;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSkeletonsOverTime());
    }

    IEnumerator SpawnSkeletonsOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);

            newSkeleton = Instantiate(SkeletonPrefab, new Vector3(Random.Range(-36, 36), 6, 0), Quaternion.identity);

        }
    }
}
