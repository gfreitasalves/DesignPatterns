namespace DesignPaterns.Console.Patterns.Behavioral.Iterator
{
    using System;

    /// <summary>
    /// Iterator Pattern: This pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
    /// </summary>
    public class IteratorPattern
    {
        public static void Start()
        {
            var aggregate = new ListAggregate<int>();
            aggregate.AddItem(1);
            aggregate.AddItem(2);
            aggregate.AddItem(3);

            var iterator = aggregate.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
