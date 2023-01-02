using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity;
    public float jumpVelocity;

    public StateMachin stateNow;
    public MoveState moveState;

    public Animator anim;
    public static Animator anim1;

    private Movement movement;
    void Start()
    {  
        anim1 = anim;
        stateNow = new StateMachin();
        stateNow.Initialize(new IdleState());

        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.MoveStep(velocity, jumpVelocity);

        stateNow.CurrentState.Update(); //підключення update  
        if (movement.isMoving())
        {
            stateNow.ChangeState(new MoveState());
        }
        else
        {
            stateNow.ChangeState(new IdleState());
        }

    }
}
