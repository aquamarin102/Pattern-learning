using Zoork.Interfaces;

namespace Zoork.Enemy
{
    public class ClientFactory : AbstractFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Asteroid();
        }

        public override IPlayer CreatePlayer()
        {
          return  new Player.Player();
        }
    }
}