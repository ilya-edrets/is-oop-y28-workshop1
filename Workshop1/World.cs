using Workshop1.Entities.Buildings;
using Workshop1.Entities.Ships;

namespace Workshop1
{
    public class World
    {
        private readonly List<Ship> enemies = new List<Ship>();
        private IEnemiesFactory _enemiesFactory;

        // Простая релизация синглтона через Lazy.
        // Все проблемы многопоточки Lazy решает под капотом
        private static readonly Lazy<World> _world = new Lazy<World>(() => new World());
        public static World Insatance => _world.Value;

        private World()
        {
        }

        public Ship Player { get; set; }

        public IReadOnlyCollection<Ship> Enemies => enemies;

        public IReadOnlyCollection<Lighthouse> Lighthouses { get; set; }

        public IReadOnlyCollection<Fortress> Fortresses { get; set; }

        // Из-за использования паттерна Синглтон,
        // мы потеряли возможность передавать зависимости через конструктор.
        // Внедрение зависимостей через метод тоже считается одной из реализаций IoC,
        // но это приводит к проблеме, что пока не вызван Init объект World имеет невалидное состояние.
        public void Init(IEnemiesFactory enemiesFactory)
        {
            _enemiesFactory = enemiesFactory;

            for (int i = 0; i < 10; i++)
            {
                // В этом методе видно, что объект World
                // ничего не знает о том, как сконфигурирована фабрика
                // Он является только её потребителем - вызывает методы Create
                // Настройка фабрики выполняется за пределами потребителей
                // 
                // Если вместо внедрения объекта IEnemiesFactory сделать три абстрактных метода:
                // - public abstract Ship CreateLightShip()
                // - public abstract Ship CreateMediumShip()
                // - public abstract Ship CreateHeavyShip()
                // то мы получим паттерн Фабричный метод
                enemies.Add(_enemiesFactory.CreateLightShip());
            }

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(_enemiesFactory.CreateMediumShip());
            }

            for (int i = 0; i < 10; i++)
            {
                enemies.Add(_enemiesFactory.CreateHeavyShip());
            }
        }

    }
}
