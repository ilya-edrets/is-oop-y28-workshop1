using Workshop1.Entities.Damage;

namespace Workshop1.Entities.Ships
{
    internal class Turret : IWeapon
    {
        public void Fire(IDamagable damagable)
        {
            damagable.TakeDamage(new Missile());
        }
    }
}
