namespace ConsoleApp1;

public interface ExpressionElement
{
    public Type type { get; }
    public int priority { get; }
}