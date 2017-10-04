using System;

namespace Sixty_Editor_DLL
{
    public class Abs : Function<Integer>
    {
        public override string Template { get { return "Abs (@Value)"; } }

        private Integer value = new Integer(name: "Value");

        public Abs()
        {
            SetExpressions(value);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Abs(value));
        }
    }
}
