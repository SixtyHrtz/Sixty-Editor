namespace Sixty_Editor_DLL
{
    public class Arithmetic : Method<Integer>
    {
        public override string Template { get { return "(@A @OP @B)"; } }

        private Integer a = new Integer(name: "A");
        private Operator op = new Operator("+", "OP");
        private Integer b = new Integer(name: "B");

        public Arithmetic()
        {
            SetExpressions(a, op, b);
        }

        public override IExpression Evaluate()
        {
            switch (op.Evaluate().BaseValue)
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
