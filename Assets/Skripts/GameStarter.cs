using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;
using Zoork.Enemy;
using Zoork.Interfaces;
using Zoork.Weapon;

namespace Zoork
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private AbstractFactory _clientFactory = new ClientFactory();

        private AbstractFactory _serverFactory = new ServerFactory();

        private void Start()
        {
            IEnemy enemy1 = _clientFactory.CreateEnemy();
            IPlayer player1 = _clientFactory.CreatePlayer();

            IEnemy enemy2 = _serverFactory.CreateEnemy();
            IPlayer player2 = _serverFactory.CreatePlayer();
            
            Asteroid.CreateAsteroidEnemy(new HealthEnemy(100f, 100f));
            
            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new HealthEnemy(100f, 100f));

            Asteroid.Factory = factory;

            Asteroid.Factory.Create(new HealthEnemy(100f, 100f));
        }
    }
}