using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeController : WeaponController
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnKnife = Instantiate(weaponData.Prefab);
        spawnKnife.transform.position = transform.position; //Assing the position to be the same as this object which is parented to the player
        spawnKnife.GetComponent<knifeBehaviour>().DirectionChecker(pm.lastMovedVector); //Reference and set the direction
    }

}
