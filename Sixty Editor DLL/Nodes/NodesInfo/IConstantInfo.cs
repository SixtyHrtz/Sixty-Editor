namespace Sixty_Editor_DLL
{
    public interface IConstantInfo
    {
        string Name { get; }
        string Value { get; }

        IExpression GetConstant();
    }
}
