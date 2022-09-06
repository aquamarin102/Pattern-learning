using UnityEngine;

namespace Zoork.Weapon
{
    internal sealed class BulletShoot : MonoBehaviour
    {
        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        private readonly float _force;

        public BulletShoot(Rigidbody2D _rigidbody2D, Transform _transform, float force)
        {
            _bullet = _rigidbody2D;
            _barrel = _transform;
            _force = force;
        }

        public void Shoot()
        {
            var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }
    }
}