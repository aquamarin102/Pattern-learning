using System;
using UnityEngine;
using Zoork.Interfaces;

namespace Zoork.Weapon
{
    public class BulletPool : MonoBehaviour, IBullet
    {
        private SimplePool _simplePool;

        public void Inint(GameObject bullet)
        {
            _simplePool = new SimplePool(bullet);
        }

        public void StartGame()
        {
            var obj = _simplePool.Get();
            
            _simplePool.Return(gameObject);
        }

        private void OnDestroy()
        {
            _simplePool.Dispose();
        }

        public void Damage()
        {
            throw new NotImplementedException();
        }
    }
}