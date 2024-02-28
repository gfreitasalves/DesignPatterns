namespace DesignPaterns.Console.Patterns.Behavioral.Interpreter
{
    using System.Collections.Generic;

    // Context
    public class Context
    {
        public Dictionary<string, int> Variables { get; } = new Dictionary<string, int>();
    }

}
