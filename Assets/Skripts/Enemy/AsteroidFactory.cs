using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using Zoork.Player;

namespace Zoork.Enemy
{
    internal sealed class AsteroidFactory : IEnemyFactory
    {
        public Enemy Create(HealthEnemy hp, MaasiveAttack damage)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));

            enemy.DependencyInjectHealth(hp);

            return enemy;
        }
    }
}
