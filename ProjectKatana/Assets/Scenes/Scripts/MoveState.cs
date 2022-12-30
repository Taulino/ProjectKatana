using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Ввійшов в Стан Бігу");
    }
    public override void Update()
    {
        base.Update();
        Debug.Log("Біжу");

    }
    public override void Exit()
    {
        Debug.Log("Вийшов з Стану Бігу");
    }
}
