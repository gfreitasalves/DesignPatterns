namespace DesignPaterns.Console.Patterns.Behavioral.Interpreter
{
    using System;

    // Client code
    public static class Interpreter
    {
        public static void Start()
        {
            var context = new Context();
            context.Variables["x"] = 10;
            context.Variables["y"] = 5;

            // x + y
            IExpression expression = new AddExpression(new NumberExpression(context.Variables["x"]), new NumberExpression(context.Variables["y"]));
            int result = expression.Interpret(context);
            Console.WriteLine("Result: " + result); // Output: Result: 15
        }
    }

}
