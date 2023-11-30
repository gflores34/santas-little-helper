using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSnowmanSpawner : MonoBehaviour
{

    [SerializeField] GameObject SkeletonPrefab;
    [SerializeField] float timeToWait;
    [SerializeField] float snowmanLife;

    GameObject newSkeleton;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSkeletonsOverTime());
    }

    IEnumerator SpawnSkeletonsOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToWait);

            float currentX = transform.position.x;
            float currentY = transform.position.y;

            SkeletonPrefab.GetComponent<EnemyHandler>().enemyLife = snowmanLife;

            newSkeleton = Instantiate(SkeletonPrefab, new Vector3(Random.Range(currentX - 9, currentX + 9), Random.Range( currentY - 9, currentY + 9), 1), Quaternion.identity);

        }


    }
}
