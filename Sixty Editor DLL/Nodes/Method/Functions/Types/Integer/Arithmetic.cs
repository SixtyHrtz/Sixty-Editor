namespace Sixty_Editor_DLL
{
    public class Arithmetic : Function<Integer>
    {
        public override string Template { get { return "(@Value1 @Sign @Value2)"; } }

        private Integer value1 = new Integer(name: "Value1");
        private Operator sign = new Operator("+", "Sign");
        private Integer value2 = new Integer(name: "Value2");

        public Arithmetic()
        {
            SetExpressions(value1, sign, value2);
        }

        public override IExpression Evaluate()
        {
            switch (sign.Evaluate().BaseValue)
            {
                case "+": return new Integer(value1 + value2);
                case "-": return new Integer(value1 - value2);
                case "*": return new Integer(value1 * value2);
                case "/": return new Integer(value1 / value2);
                case "%": return new Integer(value1 % value2);
                default: return null;
            }
        }
    }
}
