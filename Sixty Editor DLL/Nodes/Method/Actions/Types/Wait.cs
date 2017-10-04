using System.Threading.Tasks;

namespace Sixty_Editor_DLL
{
    public class Wait : Action
    {
        public override string Template { get { return "Wait(@a)"; } }

        private Float a = new Float(name: "a");

        public Wait()
        {
            SetExpressions(a);
        }

        public override void Execute()
        {
            Task.Delay((int)(a * 1000)).Wait();
        }
    }
}
