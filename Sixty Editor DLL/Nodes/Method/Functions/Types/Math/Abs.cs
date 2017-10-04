using System;

namespace Sixty_Editor_DLL
{
    public class Abs : Function<Integer>
    {
        public override string Template { get { return "Abs(@a)"; } }

        private Integer a = new Integer(name: "a");

        public Abs()
        {
            SetExpressions(a);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Abs(a));
        }
    }
}
