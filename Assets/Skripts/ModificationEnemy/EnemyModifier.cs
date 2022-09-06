using System.Collections;
using System.Collections.Generic;
using Skripts.Enemy;
using UnityEngine;

namespace Zoork.ModificationEnemy
{
    internal class EnemyModifier 
    {
        protected BossEnemy _bossEnemy;
        protected EnemyModifier Next;

        public EnemyModifier(BossEnemy bossEnemy)
        {
            _bossEnemy = bossEnemy;
        }

        public void Add(EnemyModifier cm)
        {
            if (Next != null)
            {
                Next.Add(cm);
            }
            else
            {
                Next = cm;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}