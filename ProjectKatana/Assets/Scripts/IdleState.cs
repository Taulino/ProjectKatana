using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    private Animator IdleAnim;
    public override void Enter()
    {
       
        base.Enter();
        IdleAnim = Player.anim1;
        IdleAnim.Play("IdleAnim",0,0.00f);
        Debug.Log("Ввійшов в Стан Спокою");
    }
    public override void Exit()
    {
        Debug.Log("Вийшов з Стану Спокою");
    }
}
