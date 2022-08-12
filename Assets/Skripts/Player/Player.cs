using UnityEngine;
using Zoork.Interfaces;
using Zoork.Weapon;

namespace Zoork.Player
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _maxHP;
        [SerializeField] private float _changeHP = -1f;
        [SerializeField] private float _force;

        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;

        private Camera _camera;
        private Health _health;
        private BulletShoot _bulletShoot;
        private Ship _ship;

        private const string _horizontal = "Horizontal";
        private const string _vertical = "Vertical";
        private const string _fire = "Fire1";

        private void Awake()
        {
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed,_acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
            _health = new Health(_maxHP, _maxHP);
            _bulletShoot = new BulletShoot(_bullet, _barrel, _force);
        }

        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
            
            _ship.Move(Input.GetAxis(_horizontal), Input.GetAxis(_vertical), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAccelerarion();   
            }
            
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }
            
            if (Input.GetButtonDown(_fire))
            {
                _bulletShoot.Shoot();
            }
        }

        private void OnCollisionEnter2D(Collision2D col)
        {
           _health.ChangedHP(_changeHP, gameObject);
        }
    }
}
