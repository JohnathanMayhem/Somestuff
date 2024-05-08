namespace ConsoleApp1;

public class Expression: IExpression
{
    private List<ExpressionElement> elements;
    public Expression(List<ExpressionElement> expressionElements)
    {
        elements = expressionElements;
    }
    public string toString()
    {
        return "";
    }

    public double evaluate()
    {
        return 0;
    }
}