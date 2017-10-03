namespace Sixty_Editor_DLL
{
    public class And : Method<Boolean>
    {
        public override string Template { get { return "And(@a, @b)"; } }

        private Boolean a = new Boolean(name: "a");
        private Boolean b = new Boolean(name: "b");

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
