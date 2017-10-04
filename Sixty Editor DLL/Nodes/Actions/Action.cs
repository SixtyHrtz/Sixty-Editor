namespace Sixty_Editor_DLL
{
    public abstract class Action : Method<Null>, IAction
    {
        public sealed override IExpression Evaluate()
        {
            return null;
        }

        public abstract void Execute();
    }
}
