using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachin stateNow;
    public MoveState moveState;
    void Start()
    {
        stateNow = new StateMachin();
        stateNow.Initialize(new IdleState());
    }

    // Update is called once per frame
    void Update()
    {
        stateNow.CurrentState.Update(); //���������� update  
        if (Input.GetButtonDown("Fire1"))
        {
            stateNow.ChangeState(new MoveState());
        }

    }
}
