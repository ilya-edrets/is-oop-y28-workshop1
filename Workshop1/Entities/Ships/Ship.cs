using Workshop1.Entities.Damage;
using Workshop1.Entities.Sailors;

namespace Workshop1.Entities.Ships
{
    public abstract class Ship : IDamagable, IPrototype<Ship>
    {
        private readonly List<Person> _crew;

        public IReadOnlyCollection<Person> Crew => _crew;

        public string Name { get; }

        public int HealthPoints { get; set; }

        public Ship(string name, List<Person> crew)
        {
            Name = name;
            _crew = crew;
        }

        public void TakeDamage(IDamageSource source)
        {
            throw new NotImplementedException();
        }

        public abstract Ship Clone();
    }
}
