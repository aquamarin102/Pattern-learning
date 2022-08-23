using UnityEngine;
using Zoork.Enemy;

public class PrototypeEnemy : MonoBehaviour
{
  
  private HealthEnemy hp;
  
  private void DeepCopyEnemy()
  {
    var origin = AsteroidFactory.Create(hp);
    var deepCopy = origin.DeepCopy();
  }
}
