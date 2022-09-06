namespace Skripts.Enemy
{
    internal sealed class BossEnemy : Zoork.Enemy.Enemy
    {
        public string Name;
        public float Attack;
        public float Defense;
        
        public BossEnemy(string name, float attack, float defense)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
        }

    }
}