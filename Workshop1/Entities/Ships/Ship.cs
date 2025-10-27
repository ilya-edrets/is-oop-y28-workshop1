using Workshop1.Entities.Damage;
using Workshop1.Entities.Sailors;

namespace Workshop1.Entities.Ships
{
    public abstract class Ship : IDamagable
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

        }

        public void TakeMissleDamage(Missile missile)
        {
            HealthPoints -= missile.Payload;
            if(missile.ExplosionRadius > 0.5)
            {
                _crew.RemoveAt(0);
            }
        }
    }
}
