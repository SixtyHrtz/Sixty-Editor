namespace Sixty_Editor_DLL
{
    public class Random : Method<Integer>
    {
        public override string Template { get { return "Случайное(@A, @B)"; } }

        private Integer a = new Integer(name: "A");
        private Integer b = new Integer(name: "B");

        public Random()
        {
            SetExpressions(a, b);
        }

        public override IExpression Evaluate()
        {
            return new Integer(MathSE.Random(a, b));
        }
    }
}
