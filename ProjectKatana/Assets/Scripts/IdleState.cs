using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Ввійшов в Стан Спокою");
    }
    public override void Exit()
    {
        Debug.Log("Вийшов з Стану Спокою");
    }
}
