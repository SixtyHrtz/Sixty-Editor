namespace Sixty_Editor_DLL
{
    public class StringToInteger : Function<Integer>
    {
        public override string Template { get { return "Integer (@String)"; } }

        private String str = new String("string", "String");

        public StringToInteger()
        {
            SetExpressions(str);
        }

        public override IExpression Evaluate()
        {
            int.TryParse(str, out int result);
            return new Integer(result);
        }
    }
}
