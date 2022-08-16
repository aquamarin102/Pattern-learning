using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zoork.Weapon
{
    public class BulletPool : MonoBehaviour
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
    }
}