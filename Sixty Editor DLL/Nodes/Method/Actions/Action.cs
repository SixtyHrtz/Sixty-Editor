namespace Sixty_Editor_DLL
{
    public abstract class Action : Method, IAction
    {
        public abstract void Execute();
    }
}
