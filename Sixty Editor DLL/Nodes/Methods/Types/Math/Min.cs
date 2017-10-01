using System;

namespace Sixty_Editor_DLL
{
    public class Min : Method<Integer>
    {
        public override string Template { get { return "Минимум(@A, @B)"; } }

        private Integer a = new Integer(name: "A");
        private Integer b = new Integer(name: "B");

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
