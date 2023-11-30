using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCaneController : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedCandyCane = Instantiate(weaponData.prefab);
        spawnedCandyCane.transform.position = transform.position;
        spawnedCandyCane.GetComponent<CandyCaneBehavior>().DirectionChecker(pm.lastMovedVector);
    }
}
