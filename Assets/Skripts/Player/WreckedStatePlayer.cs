using UnityEngine;
using Zoork.Interfaces;

public class WreckedStatePlayer : IState
{
    public void Do(Context context)
    {
        Debug.Log("ConcreteStateB.DoAction: ");

        context.SetState(this);
    }


    public string Say()
    {
        Debug.Log("ConcreteStateB.Say: ");

        return "B";
    }
}
