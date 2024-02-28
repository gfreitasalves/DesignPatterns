namespace DesignPaterns.Console.Patterns.Behavioral.Interpreter
{
    // Abstract expression
    public interface IExpression
    {
        int Interpret(Context context);
    }

}
