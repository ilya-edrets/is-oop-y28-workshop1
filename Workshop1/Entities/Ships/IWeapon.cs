using Workshop1.Entities.Damage;

namespace Workshop1.Entities.Ships
{
    public interface IWeapon
    {
        void Fire(IDamagable damagable);
    }
}
