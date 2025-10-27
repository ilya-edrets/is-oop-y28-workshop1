using Workshop1.Entities.Ships;

namespace Workshop1
{
    /// <summary>
    /// Фабрика на основе прототипов
    /// Потребители фабрики не знают деталей её реализации, и работают с ней только через интерфейс IEnemiesFactory
    /// Настройка фабрики не должна выполняться потребителями
    /// Часто настройка фабрики выносится ближе к точке запуска приложения. Например, метод - Main
    /// </summary>
    public class PrototypeEnemiesFactory : IEnemiesFactory
    {
        private IPrototype<Ship> _heavyShip;
        private IPrototype<Ship> _mediumShip;
        private IPrototype<Ship> _lightShip;

        public PrototypeEnemiesFactory(heavyShip, Ship mediumShip, Ship lightShip)
        {
            _heavyShip = new Boat("", null!, new List<Entities.Sailors.Person>());
            _mediumShip = mediumShip;
            _lightShip = lightShip;
        }

        public Ship CreateHeavyShip()
        {
            return _heavyShip.Clone();
        }

        public Ship CreateLightShip()
        {
            return _lightShip.Clone();
        }

        public Ship CreateMediumShip()
        {
            return _mediumShip.Clone();
        }
    }
}
