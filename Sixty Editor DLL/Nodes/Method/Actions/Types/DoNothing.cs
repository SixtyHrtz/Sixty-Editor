namespace Sixty_Editor_DLL
{
    public class DoNothing : Action
    {
        public override string Template { get { return "Do nothing"; } }

        public override void Execute()
        {
            // Nothing to do
        }
    }
}
