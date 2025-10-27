using Workshop1.Entities.Ships;

namespace Workshop1.Builders
{
    /// <summary>
    /// Фабрика на основе билдеров
    /// Потребители фабрики не знают деталей её реализации, и работают с ней только через интерфейс IEnemyFactory
    /// Настройка фабрики не должна выполняться потребителями
    /// Часто настройка фабрики выносится ближе к точке запуска приложения. Например, метод - Main
    /// </summary>
    internal class RaftBuilderEnemyFactory : IEnemyFactory
    {
        private readonly RaftBuilder _raftBuilder;

        public RaftBuilderEnemyFactory(RaftBuilder raftBuilder)
        {
            _raftBuilder = raftBuilder;
        }

        public Ship CreateShip()
        {
            return _raftBuilder.Build();
        }
    }
}
