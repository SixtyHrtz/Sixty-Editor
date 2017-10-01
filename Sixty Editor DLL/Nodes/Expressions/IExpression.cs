namespace Sixty_Editor_DLL
{
    public interface IExpression
    {
        string Name { get; set; }
        string BaseValue { get; set; }
        IMethod Method { get; set; }

        ExpressionType ExpressionType { get; set; }
        ExpressionType AllowedExpressionType { get; }

        IConstantInfo[] Constants { get; }
        IMethodInfo[] Methods { get; }

        IExpression Evaluate();
    }
}
