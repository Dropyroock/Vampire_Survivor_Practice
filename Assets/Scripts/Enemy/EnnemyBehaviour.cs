using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyBehaviour : MonoBehaviour
{

    public EnemyScriptableObject enemyData;
    Transform target;


    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerCharacter_Movement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, enemyData.MoveSpeed * Time.deltaTime); //Move towards target
    }
}
