namespace DesignPaterns.Console.Patterns.Behavioral.Iterator
{
    // Aggregate interface
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
