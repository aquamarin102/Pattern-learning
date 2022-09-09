using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoork.Interfaces
{
    public interface IHit
    {
        event Action<float> OnHitChange;
        void Hit(float damage);
    }
}