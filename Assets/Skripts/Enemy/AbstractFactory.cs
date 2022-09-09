using Zoork.Interfaces;

namespace Zoork.Enemy
{
    public abstract class AbstractFactory
    {
        public abstract IEnemy CreateEnemy();

        public abstract IPlayer CreatePlayer();
    }
}