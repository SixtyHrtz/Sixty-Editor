namespace Sixty_Editor_DLL
{
    public class FloatToInteger : Function<Integer>
    {
        public override string Template { get { return "Integer (@Value)"; } }

        private Float value = new Float(name: "Value");

        public FloatToInteger()
        {
            SetExpressions(value);
        }

        public override IExpression Evaluate()
        {
            return new Integer((int)value);
        }
    }
}
