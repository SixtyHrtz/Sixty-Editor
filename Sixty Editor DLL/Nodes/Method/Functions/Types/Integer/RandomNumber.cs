namespace Sixty_Editor_DLL
{
    public class RandomNumber : Function<Integer>
    {
        public override string Template { get { return "Random integer between (@Value1) and (@Value2)"; } }

        private Integer value1 = new Integer(name: "Value1");
        private Integer value2 = new Integer(name: "Value2");

        public RandomNumber()
        {
            SetExpressions(value1, value2);
        }

        public override IExpression Evaluate()
        {
            return new Integer(MathSE.Random(value1, value2));
        }
    }
}
