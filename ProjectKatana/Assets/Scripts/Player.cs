using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachin stateNow;
    public MoveState moveState;

    public Animator anim;
    public static Animator anim1;

    void Start()
    {  
        anim1 = anim;
        stateNow = new StateMachin();
        stateNow.Initialize(new IdleState());
      
    }

    // Update is called once per frame
    void Update()
    {
        stateNow.CurrentState.Update(); //підключення update  
        if (Input.GetButtonDown("Fire1"))
        {
            stateNow.ChangeState(new MoveState());
        }

    }
}
