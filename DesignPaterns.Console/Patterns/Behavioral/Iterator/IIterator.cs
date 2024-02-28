namespace DesignPaterns.Console.Patterns.Behavioral.Iterator
{
    // Iterator interface
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
