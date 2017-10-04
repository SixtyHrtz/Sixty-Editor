using System.Threading.Tasks;

namespace Sixty_Editor_DLL
{
    public class Wait : Action
    {
        public override string Template { get { return "Wait (@Value)"; } }

        private Float value = new Float(name: "Value");

        public Wait()
        {
            SetExpressions(value);
        }

        public override void Execute()
        {
            Task.Delay((int)(value * 1000)).Wait();
        }
    }
}
