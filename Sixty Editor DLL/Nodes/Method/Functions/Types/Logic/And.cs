namespace Sixty_Editor_DLL
{
    public class And : Function<Boolean>
    {
        public override string Template { get { return "(@Value1 and @Value2)"; } }

        private Boolean value1 = new Boolean(name: "Value1");
        private Boolean value2 = new Boolean(name: "Value2");

        public And()
        {
            SetExpressions(value1, value2);
        }

        public override IExpression Evaluate()
        {
            return new Boolean(value1 && value2);
        }
    }
}
