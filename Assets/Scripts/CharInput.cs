using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class CharInput : MonoBehaviour
{

    Movement movement;

    public Animator animator;

    [SerializeField] AnimatorController animatorUp;
    [SerializeField] AnimatorController animatorDown;
    [SerializeField] AnimatorController animatorLeft;
    [SerializeField] AnimatorController animatorRight;

    void Start()
    {
       movement = GetComponent<Movement>();
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 vel = Vector3.zero;

        float diagVel = Mathf.Sqrt(2) / 2;

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.D))
            {
                vel.x = diagVel;
                vel.y = diagVel;
                animator.runtimeAnimatorController = animatorRight;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                vel.x = -1 * diagVel;
                vel.y = diagVel;
                animator.runtimeAnimatorController = animatorLeft;
            }
            else
            {
                vel.y = 1;
                animator.runtimeAnimatorController = animatorUp;
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.D))
            {
                vel.x = diagVel;
                vel.y = -1 * diagVel;
                animator.runtimeAnimatorController = animatorRight;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                vel.x = -1 * diagVel;
                vel.y = -1 * diagVel;
                animator.runtimeAnimatorController = animatorLeft;
            }
            else
            {
                vel.y = -1;
                animator.runtimeAnimatorController = animatorDown;
            }
        }
        else if (Input.GetKey(KeyCode.A))
        {
            vel.x = -1;
            animator.runtimeAnimatorController = animatorLeft;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            vel.x = 1;
            animator.runtimeAnimatorController = animatorRight;
        }

        movement.CharMovement(vel);

    }
}
