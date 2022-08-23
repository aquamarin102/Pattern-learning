using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using Zoork.Interfaces;

namespace Zoork.Enemy
{
    public abstract class Enemy : MonoBehaviour, IEnemy
    {
        public static IEnemyFactory Factory;
        public HealthEnemy Health { get; private set; }

        public static Asteroid CreateAsteroidEnemy(HealthEnemy hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));

            enemy.Health = hp;

            return enemy;
        }

        public void DependencyInjectHealth(HealthEnemy hp)
        {
            Health = hp;
        }

        public void Attack()
        {
            
        }
    }
}
