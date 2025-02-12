using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

public class PlayerCharacter_Movement : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] GameObject scythePrefab;
    [SerializeField] float scytheTimer = 2;
    float currentScytheTimer;
    Rigidbody2D rb;
   
    //Movement
    [HideInInspector]
    public Vector2 moveDir;
    [HideInInspector]
    public Vector2 lastMovedVector;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticallVector;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lastMovedVector = new Vector2(1, 0f); // Set a stating direction for spawn
    }

    private void Update()
    {
        InputManagement();
        /*
        currentScytheTimer -= Time.deltaTime;
        if (currentScytheTimer <= 0)
        {
            //spawn le scythe
            for (int i = 0; i < 3; i++) 
            {
                Quaternion rot = Quaternion.Euler(0, 0, Random.Range(0, 360f));
                //Instantiate(scythePrefab, transform.position, Quaternion.identity);
                GameObject scythe = ObjectPool.GetInstance().GetPooledObject();
                scythe.transform.SetPositionAndRotation(transform.position, rot);
                scythe.SetActive(true);
            }
            currentScytheTimer += scytheTimer; 
        }
         */
    }

    void FixedUpdate()
    {
        Move();
    }

    void InputManagement()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;

        if (moveDir.x != 0)
        {
            lastHorizontalVector = moveDir.x;
            lastMovedVector = new Vector2(lastHorizontalVector, 0f); // Last moved X
        }
        if (moveDir.y != 0)
        {
            lastVerticallVector = moveDir.y;
            lastMovedVector = new Vector2(0f, lastVerticallVector); // Last moved Y
        }

        if (moveDir.y != 0 && moveDir.y != 0)
        {
            lastMovedVector = new Vector2(lastHorizontalVector, lastVerticallVector); // While moving
        }
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x * movespeed, moveDir.y * movespeed);
    }
        
}
