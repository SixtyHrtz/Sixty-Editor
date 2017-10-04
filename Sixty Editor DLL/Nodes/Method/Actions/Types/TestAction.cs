namespace Sixty_Editor_DLL
{
    public class TestAction : Action
    {
        public override string Template { get { return "Test action (@Boolean, @Integer, @Float, @String)"; } }

        private Boolean boolean = new Boolean(name: "Boolean");
        private Integer integer = new Integer(name: "Integer");
        private Float flo = new Float(name: "Float");
        private String str = new String("string", "String");

        public TestAction()
        {
            SetExpressions(boolean, integer, flo, str);
        }

        public override void Execute()
        {
            bool a = boolean;
            int b = integer;
            float c = flo;
            string d = str;
        }
    }
}
