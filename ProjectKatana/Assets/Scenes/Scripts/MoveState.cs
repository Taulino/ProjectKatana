using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : State
{
    private Animator RunAnim;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("������ � ���� ����");
        RunAnim = Player.anim1;
        RunAnim.Play("RunAnimation",0,0.00f);
    }
    public override void Update()
    {
        base.Update();
        Debug.Log("����");

    }
    public override void Exit()
    {
        Debug.Log("������ � ����� ����");
    }
}
