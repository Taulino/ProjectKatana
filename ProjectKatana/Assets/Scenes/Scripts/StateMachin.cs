using UnityEngine;

public class StateMachin 
{
   public State CurrentState { get; set; }
   public void Initialize(State startState)//�� � �� Start, ����������� ������
    {
        CurrentState = startState;//��������� ���������
        CurrentState.Enter();
    }

   
    public void ChangeState(State newState)
    {
        CurrentState.Exit();
        CurrentState = newState;//��������� ������ ����� 
        CurrentState.Enter();
    }
}
