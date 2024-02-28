namespace DesignPaterns.Console.Patterns.Behavioral.Iterator
{
    using System.Collections.Generic;

    // Concrete Aggregate
    public class ListAggregate<T> : IAggregate<T>
    {
        private List<T> _list = new List<T>();

        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public IIterator<T> CreateIterator()
        {
            return new ListIterator<T>(_list);
        }
    }
}
