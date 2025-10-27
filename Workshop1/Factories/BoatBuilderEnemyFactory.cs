using Workshop1.Builders;
using Workshop1.Entities.Ships;

namespace Workshop1.Factories
{
    // Смотри RaftBuilderEnemyFactory
    internal class BoatBuilderEnemyFactory : IEnemyFactory
    {
        public BoatBuilderEnemyFactory(BoatBuilder boatBuilder)
        {
        }

        public Ship CreateShip()
        {
            throw new NotImplementedException();
        }
    }
}
