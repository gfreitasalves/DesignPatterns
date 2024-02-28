using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Console.Patterns.Behavioral.Interpreter
{

    // Non-terminal expression
    public class AddExpression : IExpression
    {
        private readonly IExpression _left;
        private readonly IExpression _right;

        public AddExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) + _right.Interpret(context);
        }
    }

}
