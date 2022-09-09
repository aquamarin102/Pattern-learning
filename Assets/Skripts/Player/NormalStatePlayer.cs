using UnityEngine;
using Zoork.Interfaces;

namespace Zoork.Player
{
    public class NormalStatePlayer : IState
    {
        public void Do(Context context)
        {
            Debug.Log("ConcreteStateA.DoAction: ");

            context.SetState(this);
        }

        public string Say()
        {
            Debug.Log("ConcreteStateA.Say: ");

            return "A";
        }
    }
}