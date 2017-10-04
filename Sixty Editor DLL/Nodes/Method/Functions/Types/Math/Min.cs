using System;

namespace Sixty_Editor_DLL
{
    public class Min : Function<Integer>
    {
        public override string Template { get { return "Min(@a, @b)"; } }

        private Integer a = new Integer(name: "a");
        private Integer b = new Integer(name: "b");

        public Min()
        {
            SetExpressions(a, b);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Min(a, b));
        }
    }
}
