using UnityEngine;

public class StateMachin 
{
   public State CurrentState { get; set; }
   public void Initialize(State startState)//те й що Start, викликається спершу
    {
        CurrentState = startState;//присвоєння параметру
        CurrentState.Enter();
    }

   
    public void ChangeState(State newState)
    {
        CurrentState.Exit();
        CurrentState = newState;//присвоєння нового стану 
        CurrentState.Enter();
    }
}
