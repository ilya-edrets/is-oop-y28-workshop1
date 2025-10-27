using Workshop1.Builders;
using Workshop1.Entities.Sailors;
using Workshop1.Entities.Ships;
using Workshop1.Factories;

namespace Workshop1
{
    internal class Program
    {
        public void Main()
        {
            var raftBuilder = new RaftBuilder();
            raftBuilder
                .WithHealthPoints(100)
                .WithName("raft")
                .Build();

            var heavyPrototype = new Submarine("heavy ship", new SimpleArmor(), new Turret(), new List<Person>());

            var factory1 = new RaftBuilderEnemyFactory(raftBuilder);
            var factory2 = new BoatBuilderEnemyFactory(new BoatBuilder());
            var factory3 = new PrototypeEnemyFactory(heavyPrototype);

            World.Insatance.Init(factory1, factory2, factory3);

            // В отличие от статического класса,
            // Синглтон - это объект, а знаичт его можно передавать как аргумент в методы
            // и возвращать как результат выполнения метода.
            PrintWorld(World.Insatance);
        }

        void PrintWorld(World world)
        {
            // ...
        }
    }
}
