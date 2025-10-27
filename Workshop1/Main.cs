namespace Workshop1
{
    internal class Program
    {
        public void Main()
        {
            var factory = new BuilderEnemiesFactory();

            factory
                .RaftBuilder
                .WithHealthPoints(100)
                .WithName("raft")
                .Build();

            World.Insatance.Init(factory);

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
