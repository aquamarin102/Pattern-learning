using UnityEngine;

namespace Zoork.Player
{
    internal sealed class AccelerationMove : PlayerMove
    {
        private readonly float _acceleration;

        public AccelerationMove(Transform transform, float speed, float acceleration) : base(transform, speed)
        {
            _acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += _acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}