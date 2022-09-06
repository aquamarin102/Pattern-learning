using System;
using UnityEngine;
using Zoork.ModificationEnemy;

namespace Skripts.Enemy
{
    internal sealed class SpawnBossEnemy : MonoBehaviour
    {
        private void Start()
        {
            var BOSS = new BossEnemy("PirateShip", 1f, 1f);

            var root = new EnemyModifier(BOSS);
            root.Add(new AddAttackModification(BOSS, 5f));
            root.Handle();
        }
    }
}