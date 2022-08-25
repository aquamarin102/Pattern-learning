using UnityEngine;

namespace Zoork.Homework5
{
    public interface IAim
    {
        Transform BarrelPositionAim { get; }
        GameObject AimInstance { get; }
    }
}