namespace ConsoleApp1;

public class ExpressionOperand: ExpressionElement
{
    public Type type { get; set; }
    public int priority { get; }
    public OperandType operandType { get; }

    public ExpressionOperand(OperandType t)
    {
        operandType = t;
        switch (t)
        {
            case (OperandType.DIV):
                priority = 4;
                break;
            case (OperandType.MUL):
                priority = 4;
                break;
            case (OperandType.SUM):
                priority = 3;
                break;
            case (OperandType.SUB):
                priority = 3;
                break;
            case (OperandType.BRACKET_RIGHT):
                priority = 2;
                break;
            case (OperandType.BRACKET_LEFT):
                priority = 1;
                break;
        }
    }

    
}