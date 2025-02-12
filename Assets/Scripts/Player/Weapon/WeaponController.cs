using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("Weapon Stats")]
    public WeaponScriptableObject weaponData;
    float currentCooldown;
    float lifeTime;

    protected PlayerCharacter_Movement pm;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        pm = FindAnyObjectByType<PlayerCharacter_Movement>();
        currentCooldown = weaponData.CooldownDuration;  //Wait for the cooldown
        lifeTime = weaponData.LifeTime;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if (currentCooldown <= 0)
        {
            Attack();
        }

        //lifeTime -= Time.deltaTime;
        //if (lifeTime < 0)
        //{
        //    gameObject.SetActive(false);
        //}
    }

    protected virtual void Attack()
    {
        currentCooldown = weaponData.CooldownDuration;
    }
}
