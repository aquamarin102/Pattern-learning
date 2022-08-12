using UnityEngine;
using Zoork.Interfaces;

namespace Zoork.Player
{
    internal class PlayerMove : IMove
    {
        private readonly Transform _transform;
        private Vector3 _move;
        private Rigidbody _rigidbody;
    
        public float Speed { get; protected set; }
    
        public PlayerMove(Transform transform, float speed)
        {
            _transform = transform;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            
            
            _move.Set(horizontal * speed, vertical * speed, 0);
            
            _transform.localPosition += _move;
        } 
    }
}