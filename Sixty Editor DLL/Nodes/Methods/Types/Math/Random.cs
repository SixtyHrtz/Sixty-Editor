namespace Sixty_Editor_DLL
{
    public class Random : Method<Integer>
    {
        public override string Template { get { return "Random(@a, @b)"; } }

        private Integer a = new Integer(name: "a");
        private Integer b = new Integer(name: "b");

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
