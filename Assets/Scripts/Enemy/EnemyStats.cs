using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public EnemyScriptableObject enemyData;

    //Current stats
    float currentMoveSpeed;
    float currentHealth;
    float currentDamage;


    // Start is called before the first frame update
    void Awake()
    {
        currentMoveSpeed = enemyData.MoveSpeed;
        currentHealth = enemyData.MaxHealth;
        currentDamage = enemyData.Damage;
    }

    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;

        if (currentHealth <= 0)
        {
            //SoundPlayer.GetInstance().PlayDeathAudio();
            Kill();
        }
    }

    public void Kill()
    {
        Destroy(gameObject);
    }
}
