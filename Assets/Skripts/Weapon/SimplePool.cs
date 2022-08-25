using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;


namespace Zoork.Weapon
{
    public class SimplePool : IDisposable
    {
        private readonly Stack<GameObject> _pool = new Stack<GameObject>();
        private readonly GameObject _bellet;

        public SimplePool(GameObject prefab, int initialCount = 0)
        {
            _bellet = prefab;

            for (var i = 0; i < initialCount; i++)
            {
                Get();
            }
        }

        public GameObject Get()
        {
            GameObject result = (_pool.Count == 0) ? GameObject.Instantiate(_bellet) : _pool.Pop();

            return result;
        }

        public void Return(GameObject gameObject)
        {
            _pool.Push(gameObject);
        }
        


        public void Dispose()
        {
            foreach (var gameObject in _pool)
            {
                Object.Destroy(gameObject);
            }
            
            _pool.Clear();
        }
    }
}
