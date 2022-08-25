using Zoork.Enemy;
using Zoork.Interfaces;

namespace Zoork.Player
{
    public sealed class MaasiveAttack : IAttack
    {
        public float Damage { get; set; }

        public MaasiveAttack(float damage)
        {
             Damage = damage;
        }
        
        public void Attack(float Damage)
        {
            throw new System.NotImplementedException();
        }
    }
}