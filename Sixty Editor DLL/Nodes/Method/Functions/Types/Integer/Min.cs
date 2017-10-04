using System;

namespace Sixty_Editor_DLL
{
    public class Min : Function<Integer>
    {
        public override string Template { get { return "Min (@Value1, @Value2)"; } }

        private Integer value1 = new Integer(name: "Value1");
        private Integer value2 = new Integer(name: "Value2");

        public Min()
        {
            SetExpressions(value1, value2);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Min(value1, value2));
        }
    }
}
