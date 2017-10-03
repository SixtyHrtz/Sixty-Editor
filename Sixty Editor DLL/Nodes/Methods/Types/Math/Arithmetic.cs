namespace Sixty_Editor_DLL
{
    public class Arithmetic : Method<Integer>
    {
        public override string Template { get { return "(@a @sign @b)"; } }

        private Integer a = new Integer(name: "a");
        private Operator sign = new Operator("+", "sign");
        private Integer b = new Integer(name: "b");

        public Arithmetic()
        {
            SetExpressions(a, sign, b);
        }

        public override IExpression Evaluate()
        {
            switch (sign.Evaluate().BaseValue)
            {
                case "+": return new Integer(a + b);
                case "-": return new Integer(a - b);
                case "*": return new Integer(a * b);
                case "/": return new Integer(a / b);
                default: return null;
            }
        }
    }
}
