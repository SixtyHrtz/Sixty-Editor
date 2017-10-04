using System;

namespace Sixty_Editor_DLL
{
    public class Max : Function<Integer>
    {
        public override string Template { get { return "Max (@Value1, @Value2)"; } }

        private Integer value1 = new Integer(name: "Value1");
        private Integer value2 = new Integer(name: "Value2");

        public Max()
        {
            SetExpressions(value1, value2);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Max(value1, value2));
        }
    }
}
