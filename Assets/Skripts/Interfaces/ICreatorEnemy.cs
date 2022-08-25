using Zoork.Enemy;
using Zoork.Player;

namespace Interfaces
{
    public interface IEnemyFactory
    {
        Enemy Create(HealthEnemy hp, MaasiveAttack damage);
    }
    
}