using Workshop1.Entities.Damage;
using Workshop1.Entities.Sailors;

namespace Workshop1.Entities.Ships
{
    public class Submarine : Ship, IPrototype<Submarine>
    {
        public IArmor Armor { get; }

        public IWeapon Weapon { get; }

        public Submarine(string name, IArmor armor, IWeapon weapon, List<Person> crew) : base(name, crew)
        {
            Armor = armor;
            Weapon = weapon;
        }

        public void Fire(IDamagable damagable)
        {
            Weapon.Fire(damagable);
        }

        public Submarine Clone()
        {
            // Создает поверхностную копию
            // В большинстве случаев использование MemberwiseClone будет ошибкой
            return (Submarine)MemberwiseClone();
        }
    }
}
