using Workshop1.Entities.Ships;

namespace Workshop1
{
    /// <summary>
    /// Интерфейс абстрактной фабрики
    /// В нём должны быть только методы, которые что-то создают
    /// </summary>
    public interface IEnemiesFactory
    {
        Ship CreateLightShip();

        Ship CreateMediumShip();

        Ship CreateHeavyShip();
    }
}
