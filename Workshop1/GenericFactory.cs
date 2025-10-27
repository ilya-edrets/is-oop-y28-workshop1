using Workshop1.Entities.Ships;

namespace Workshop1
{

    /// <summary>
    /// Очень часто в стандартной библиотеке дотнета можно встретить фабрики,
    /// которые содержат множество именованных билдеров (например, HttpClientFactory)
    /// В этом случае клиенты, при создании нового объекта через фабрику,
    /// должны передавать имя (или тип) создаваевого объекта
    /// Настройка такой фабрики так же делается где-то ближе к точке входа,
    /// и так же при настройке нужно указывать имя (или тип) настраиваемого объекта
    /// 
    /// Например, в этом воркшопе, можно было бы использовать такую фабрику
    /// и объект World указывал бы какие корабли нужно строить:
    /// _factory.CreateShip("boat")
    /// _factory.CreateShip("raft")
    /// _factory.CreateShip("submarine")
    /// </summary>

    public interface IGenericFactory
    {
        // Интерфейс фабрики - только метод CreateShip.
        // Метод WithName это часть реализации и он не должен быть доступен потребителям
        Ship CreateShip(string name);
    }

    public class GenericFactory
    {
        private readonly Dictionary<string, ShipBuilder> _builders = new();

        public Ship CreateShip(string name)
        {
            var builder = _builders[name];
            return builder.Build();
        }

        public ShipBuilder WithName(string name)
        {
            if (_builders.TryGetValue(name, out var builder))
            {
                return builder;
            }

            builder = new ShipBuilder();
            _builders[name] = builder;
            return builder;
        }
    }

    public class ShipBuilder
    {
        public ShipBuilder() { }

        public Ship Build()
        {
            throw new NotImplementedException();
        }
    }
}
