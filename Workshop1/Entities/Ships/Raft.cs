using Workshop1.Entities.Sailors;

namespace Workshop1.Entities.Ships
{
    public class Raft : Ship, IPrototype<Raft>
    {
        public Raft(string name, List<Person> crew) : base(name, crew)
        {
        }

        public Raft Clone()
        {
            // Создает поверхностную копию
            // В большинстве случаев использование MemberwiseClone будет ошибкой
            return (Raft)MemberwiseClone();
        }
    }
}
