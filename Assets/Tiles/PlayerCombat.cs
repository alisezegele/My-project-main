using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
           Attack(); 
        }
    }

    void Attack()
    {
        // attack animation
        animator.SetTrigger("attack");
        // detect enemies in range
        // apply damage
    }
}
