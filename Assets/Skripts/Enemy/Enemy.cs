using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using Zoork.Interfaces;
using Zoork.Player;

namespace Zoork.Enemy
{
    public abstract class Enemy : MonoBehaviour, IEnemy, IHit
    {
        public static IEnemyFactory Factory;

        private readonly IAttack _attack;
        
        public HealthEnemy Health { get; private set; }

        public MaasiveAttack AttackEnemy { get; private set; } 

        public static Asteroid CreateAsteroidEnemy(HealthEnemy hp, MaasiveAttack attack)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));

            enemy.Health = hp;
            enemy.AttackEnemy = attack;
            
            return enemy;
        }

        public void DependencyInjectHealth(HealthEnemy hp)
        {
            Health = hp;
        }

        public void Attack()
        {
            
        }

        public event Action<float> OnHitChange = delegate(float f) {  };
        public void Hit(float damage)
        {
            OnHitChange.Invoke(damage);
        }
    }
}
