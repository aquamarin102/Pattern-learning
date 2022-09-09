

namespace Zoork.Enemy
{


    public sealed class HealthEnemy
    {
        public float Max { get; }
        public float Current { get; private set; }

        public HealthEnemy(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }

    }
}
