namespace ConsoleApp1;

public class ExpressionBuilder
{
    private List<ExpressionElement> elements;

    public ExpressionBuilder()
    {
        elements = new List<ExpressionElement>();
    }
    

    public Expression GetExpression() 
    {
        Stack<ExpressionElement> stack = new Stack<ExpressionElement>();
        List<ExpressionElement> result = new List<ExpressionElement>();
        foreach (ExpressionElement elem in elements)
        {
            switch (elem.type)
            {
                case Type.VALUE:
                    result.Add(elem);
                    break;
                case Type.OPERAND:
                    if (elem.priority == 1)
                    {
                        stack.Push(elem);
                    }
            }
        }

        return new Expression(elements);
    }
}