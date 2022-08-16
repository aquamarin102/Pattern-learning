using Zoork.Enemy;

namespace Interfaces
{
    public interface IEnemyFactory
    {
        Enemy Create(HealthEnemy hp);
    }
    
}