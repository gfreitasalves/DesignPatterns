namespace DesignPaterns.Console.Patterns.Behavioral.Iterator
{
    using System;
    using System.Collections.Generic;

    // Concrete Iterator
    public class ListIterator<T> : IIterator<T>
    {
        private List<T> _list;
        private int _index = 0;

        public ListIterator(List<T> list)
        {
            _list = list;
        }

        public bool HasNext()
        {
            return _index < _list.Count;
        }

        public T Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more elements to iterate");
            }

            return _list[_index++];
        }
    }
}
