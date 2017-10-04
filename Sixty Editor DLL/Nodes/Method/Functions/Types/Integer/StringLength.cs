namespace Sixty_Editor_DLL
{
    public class StringLength : Function<Integer>
    {
        public override string Template { get { return "Length of (@String)"; } }

        private String str = new String("string", "String");

        public StringLength()
        {
            SetExpressions(str);
        }

        public override IExpression Evaluate()
        {
            return new Integer(((string)str).Length);
        }
    }
}
