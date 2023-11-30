using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator am;
    PlayerMovement pm;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        am = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x == 0 && pm.moveDir.y == 0)
        {
            am.SetBool("Idle", true);
            am.SetBool("Run_Left", false);
            am.SetBool("Run_Right", false);
            am.SetBool("Run_Up", false);
            am.SetBool("Run_Down", false);
        }
        else if (pm.moveDir.x >= 1 && pm.moveDir.y == 0)
        {
            
            am.SetBool("Run_Left", false);
            am.SetBool("Run_Right", true);
            am.SetBool("Run_Up", false);
            am.SetBool("Run_Down", false);
            am.SetBool("Idle", false);
        }
        else if (pm.moveDir.x < 0 && pm.moveDir.y == 0)
        {
            am.SetBool("Run_Left", true);
            am.SetBool("Run_Right", false);
            am.SetBool("Run_Up", false);
            am.SetBool("Run_Down", false);
            am.SetBool("Idle", false);
        }
        else if (pm.moveDir.x == 0 && pm.moveDir.y >= 1)
        {
            am.SetBool("Run_Left", false);
            am.SetBool("Run_Right", false);
            am.SetBool("Run_Up", true);
            am.SetBool("Run_Down", false);
            am.SetBool("Idle", false);
        }
        else if (pm.moveDir.x == 0 && pm.moveDir.y < 0)
        {
            am.SetBool("Run_Left", false);
            am.SetBool("Run_Right", false);
            am.SetBool("Run_Up", false);
            am.SetBool("Run_Down", true);
            am.SetBool("Idle", false);
        }
    }
}
