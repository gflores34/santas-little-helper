using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCaneBehavior : ProjectileWeaponBehavior
{

    protected override void Start()
    {
        base.Start();
    }

    private void Update()
    {
        transform.position += direction * weaponData.speed * Time.deltaTime;
    }
}
