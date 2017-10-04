using System;

namespace Sixty_Editor_DLL
{
    public class Sign : Function<Integer>
    {
        public override string Template { get { return "Sign (@Value)"; } }

        private Integer value = new Integer(name: "Value");

        public Sign()
        {
            SetExpressions(value);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Sign(value));
        }
    }
}
