using Skripts.Enemy;

namespace Zoork.ModificationEnemy
{
    internal sealed class AddAttackModification : EnemyModifier

    {
        private readonly float _attack;
        
        public AddAttackModification(BossEnemy bossEnemy, float attack) : base(bossEnemy)
        {
            _attack = attack;
        }

        public override void Handle()
        {
            _bossEnemy.Attack += _attack;
            
            base.Handle();
        }
    }
}