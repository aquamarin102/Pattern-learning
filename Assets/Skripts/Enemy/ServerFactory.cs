using Zoork.Enemy;
using Zoork.Interfaces;
using Zoork.Player;

public class ServerFactory : AbstractFactory
{
    public override IEnemy CreateEnemy()
    {
        return new ShipEnemy();
    }

    public override IPlayer CreatePlayer()
    {
        return new Player();
    }
}
