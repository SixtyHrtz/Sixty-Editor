namespace Sixty_Editor_DLL
{
    public interface IExpression
    {
        string Name { get; set; }
        string BaseValue { get; set; }
        IFunction Function { get; set; }

        ExpressionType ExpressionType { get; set; }
        ExpressionType AllowedExpressionType { get; }

        IConstantInfo[] Constants { get; }
        IFunctionInfo[] Functions { get; }

        IExpression Evaluate();
    }
}
