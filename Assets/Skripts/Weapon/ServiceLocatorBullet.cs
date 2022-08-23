
using UnityEngine;
using Zoork;
using Zoork.Interfaces;
using Zoork.Weapon;

public class ServiceLocatorBullet : MonoBehaviour
{
    private void TestServiceLocator()
    {
        var service = new BulletPool();
        ServiceLocator.SetService<IBullet>(service);

        var resolve = ServiceLocator.Resolve<IBullet>();
        resolve.Damage();
    }
}
