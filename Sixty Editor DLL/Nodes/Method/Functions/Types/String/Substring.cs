namespace Sixty_Editor_DLL
{
    public class Substring : Function<String>
    {
        public override string Template { get { return "Substring (@String, @From, @To)"; } }

        private String str = new String("string", "String");
        private Integer from = new Integer(name: "From");
        private Integer to = new Integer(name: "To");

        public Substring()
        {
            SetExpressions(str, from, to);
        }

        public override IExpression Evaluate()
        {
            return new String(((string)str).Substring(from, to - from));
        }
    }
}
