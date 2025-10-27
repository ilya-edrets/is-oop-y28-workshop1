using Workshop1.Entities.Sailors;
using Workshop1.Entities.Ships;

namespace Workshop1
{
    public class DummyFactory
    {
        // Пример абсолютно неправильной фабрики
        // Здесь, по сути, это просто обёртка над конструктором.
        // В этом случае, потребители зависят от логики создания объекта.
        // При смене входных параметров конструктора, придётся переписывать всех клиентов
        // В правильных фабриках логика создания объектов настраивается отдельно и не самими клиентами.
        public Ship CreateLightShip(string name, List<Person> crew)
        {
            return new Raft(name, crew);
        }
    }
}
