namespace Workshop1
{
    /// Рекурсивные дженерики позволяют на уровне компилятора
    /// ввести ограничения на используемый тип в T 
    /// Например: public class Raft : IPrototype<Raft> - валидно
    /// а public class Raft : IPrototype<Boat> - невалидно
    /// Так происходит потому что, в первом примере тип внутри IPrototype это Raft,
    /// который реализует интерфейс IPrototype<Raft>.
    /// Да, через рекурсию типов. Поэтому это и называется рекурсивные дженерики
    /// 
    /// out T позволяет приводить наследников в базовому типу
    /// IPrototype<Raft> -> IPrototype<Ship>
    public interface IPrototype<out T> where T : IPrototype<T>
    {
        T Clone();
    }
}
