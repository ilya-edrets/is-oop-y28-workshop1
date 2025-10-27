using Workshop1.Entities.Sailors;

namespace Workshop1.Entities.Ships
{
    public class Boat : Ship, IPrototype<Boat>
    {
        public IArmor Armor { get; set; }

        public Boat(string name, IArmor armor, List<Person> crew) : base(name, crew)
        {
            Armor = armor;
        }

        public Boat Clone()
        {
            // Создает поверхностную копию
            // В большинстве случаев использование MemberwiseClone будет ошибкой
            return (Boat)MemberwiseClone();
        }
    }
}
