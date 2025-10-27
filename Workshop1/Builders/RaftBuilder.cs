using Workshop1.Entities.Sailors;
using Workshop1.Entities.Ships;

namespace Workshop1.Builders
{
    /// <summary>
    /// Билдер не имеет интерфейса или базового класса,
    /// т.к. у одного типа крайне редко бывает несколько реализаций билдеров
    /// поэтому полиморфизм для билдеров избыточен
    /// </summary>
    public class RaftBuilder
    {
        private int _hp;
        private string? _name;
        private List<Person>? _crew;

        public RaftBuilder()
        {
        }

        public RaftBuilder WithHealthPoints(int hp)
        {
            _hp = hp;
            return this;
        }

        public RaftBuilder WithName(string name)
        {
            _name = name;
            return this;

        }

        public RaftBuilder WithCrew(List<Person> crew)
        {
            _crew = crew;
            return this;

        }

        // Билдер никогда не хранит созданный объект,
        // он хранить только значения, необходимые для создания объекта.
        public Raft Build()
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(_name);
            ArgumentNullException.ThrowIfNull(_crew);

            var raft = new Raft(_name, _crew)
            {
                HealthPoints = _hp
            };
            return raft;
        }
    }
}
