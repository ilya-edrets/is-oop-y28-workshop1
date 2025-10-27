using Workshop1.Builders;
using Workshop1.Entities.Ships;

namespace Workshop1.Factories
{
    /// <summary>
    /// Фабрика на основе прототипов
    /// 
    /// Позволяет на основе некого "эталона" нагенерировать множество идентичных объектов
    /// Например, можем создать вражескую флотилию состоящию из одинаковых кораблей
    /// </summary>
    public class PrototypeEnemyFactory : IEnemyFactory
    {
        private readonly IPrototype<Ship> _prototype;

        public PrototypeEnemyFactory(IPrototype<Ship> prototype)
        {
            _prototype = prototype;
        }

        public Ship CreateShip()
        {
            return _prototype.Clone();
        }
    }
}
