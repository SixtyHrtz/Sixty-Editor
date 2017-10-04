namespace Sixty_Editor_DLL
{
    public class ConcatenateStrings : Function<String>
    {
        public override string Template { get { return "(@String1 + @String2)"; } }

        private String str1 = new String("string1", "String1");
        private String str2 = new String("string2", "String2");

        public ConcatenateStrings()
        {
            SetExpressions(str1, str2);
        }

        public override IExpression Evaluate()
        {
            return new String(str1 + str2);
        }
    }
}
