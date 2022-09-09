using UnityEngine;

namespace Zoork.Homework5
{
    internal sealed class Aim : IAim
    {
        public Transform BarrelPositionAim { get; }
        public GameObject AimInstance { get; }
        
        public Aim(Transform barrelPositionAim, GameObject aimInstance)
        {
            BarrelPositionAim = barrelPositionAim;
            AimInstance = aimInstance;
        }
    }
}