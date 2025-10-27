using Workshop1.Builders;
using Workshop1.Entities.Buildings;
using Workshop1.Entities.Ships;

namespace Workshop1
{
    public class World
    {
        private readonly List<Ship> enemies = new List<Ship>();

        // Простая релизация синглтона через Lazy.
        // Lazy решает под капотом все проблемы связанные с многопоточностью
        private static readonly Lazy<World> _world = new Lazy<World>(() => new World());
        public static World Insatance => _world.Value;

        private World()
        {
        }

        public Ship Player { get; set; }

        public IReadOnlyCollection<Ship> Enemies => enemies;

        public IReadOnlyCollection<Lighthouse> Lighthouses { get; set; } = new List<Lighthouse>();

        public IReadOnlyCollection<Fortress> Fortresses { get; set; } = new List<Fortress>();

        // Из-за использования паттерна Синглтон,
        // мы потеряли возможность передавать зависимости через конструктор.
        // Внедрение зависимостей через метод тоже считается одной из реализаций IoC,
        // но это приводит к проблеме, что пока не вызван Init объект World имеет невалидное состояние.
        public void Init(IEnemyFactory lightEnemiesFactory, IEnemyFactory mediumEnemiesFactory, IEnemyFactory heavyEnemiesFactory)
        {
            for (int i = 0; i < 10; i++)
            {
                // В этом методе видно, что объект World
                // ничего не знает о том, как сконфигурирована фабрика
                // Он является только её потребителем - вызывает методы Create
                // Настройка фабрики выполняется за пределами потребителей
                // 
                // Если вместо внедрения объектов IEnemyFactory сделать три абстрактных метода:
                // - public abstract Ship CreateLightShip()
                // - public abstract Ship CreateMediumShip()
                // - public abstract Ship CreateHeavyShip()
                // то мы получим паттерн Фабричный метод
                enemies.Add(lightEnemiesFactory.CreateShip());
            }

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(mediumEnemiesFactory.CreateShip());
            }

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(heavyEnemiesFactory.CreateShip());
            }
        }

    }
}
