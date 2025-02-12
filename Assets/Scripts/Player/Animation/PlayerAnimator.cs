using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    //References
    Animator am;
    PlayerCharacter_Movement pm;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerCharacter_Movement>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
        {
            am.SetBool("Move", true);
            am.SetBool("Idle", false);

            SpriteDirectionChecker();
        }
        else 
        { 
            am.SetBool("Move", false);
            am.SetBool("Idle", true);
        }

    }

    void SpriteDirectionChecker()
    {
        if ((pm.lastHorizontalVector < 0))
        {
            sr.flipX = true;
        }

        else
        {
            sr.flipX = false;
        }
    }
}
