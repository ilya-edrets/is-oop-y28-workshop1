using Workshop1.Entities.Sailors;
using Workshop1.Entities.Ships;

namespace Workshop1
{
    /// <summary>
    /// Фабрика на основе билдеров
    /// Потребители фабрики не знают деталей её реализации, и работают с ней только через интерфейс IEnemiesFactory
    /// Настройка фабрики не должна выполняться потребителями
    /// Часто настройка фабрики выносится ближе к точке запуска приложения. Например, метод - Main
    /// </summary>
    internal class BuilderEnemiesFactory : IEnemiesFactory
    {
        public RaftBuilder RaftBuilder { get; }
        public BoatBuilder BoatBuilder { get; }
        public SubmarineBuilder SubmarineBuilder { get; }

        public BuilderEnemiesFactory()
        {
            RaftBuilder = new RaftBuilder();
            BoatBuilder = new BoatBuilder();
            SubmarineBuilder = new SubmarineBuilder();
        }

        public Ship CreateLightShip()
        {
            return RaftBuilder.Build();
        }

        public Ship CreateMediumShip()
        {
            return BoatBuilder.Build();
        }

        public Ship CreateHeavyShip()
        {
            return SubmarineBuilder.Build();
        }
    }

    /// <summary>
    /// Билдер не имеет интерфейса или базового класса,
    /// т.к. у одного типа крайне редко бывает несколько реализаций билдеров
    /// поэтому полиморфизм для билдеров избыточен
    /// </summary>
    public class RaftBuilder
    {
        private int _hp;
        private string _name;
        private List<Person> _crew;

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

        public Raft Build()
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(_name);
            ArgumentNullException.ThrowIfNull(_crew);

            var raft = new Raft(_name, _crew);
            raft.HealthPoints = _hp;
            return raft;
        }
    }

    public class BoatBuilder
    {
        public Boat Build()
        {
            throw new NotImplementedException();
        }
    }

    public class SubmarineBuilder
    {
        public Submarine Build()
        {
            throw new NotImplementedException();
        }
    }
}
