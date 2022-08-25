using UnityEngine;


namespace Zoork.Homework5
{
    internal sealed class ModificationAim : ModificationWeapon
    {
        private readonly IAim _aim;
        private readonly Vector3 _Position;

        public ModificationAim(IAim aim, Vector3 aimPosition)
        {
            _aim = aim;
            _Position = aimPosition;
        }
        
        protected override Weapon AddModification(Weapon weapon)
        {
            var muffler = Object.Instantiate(_aim.AimInstance,
                _Position, Quaternion.identity);
            weapon.SetBarrelPosition(_aim.BarrelPositionAim);
            return weapon;
        }
    }
}