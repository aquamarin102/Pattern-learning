using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoork.Interfaces
{
    public class Context
    {
        private IState _currentState;

        public void SetState(IState state)
        {
            _currentState = state;
        }


        public void SayCurrent()
        {
            var stateSaying = _currentState.Say();
            Debug.Log($"Context.Act: {stateSaying}");
        }
    }
}