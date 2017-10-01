namespace Sixty_Editor_DLL
{
    public class And : Method<Boolean>
    {
        public override string Template { get { return "И(@A, @B)"; } }

        private Boolean a = new Boolean(name: "A");
        private Boolean b = new Boolean(name: "B");

        public And()
        {
            SetExpressions(a, b);
        }

        public override IExpression Evaluate()
        {
            return new Boolean(a && b);
        }
    }
}
