namespace Sixty_Editor_DLL
{
    public class None : Expression<Null>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.None; }
        }

        public override string BaseValue { get; set; }

        public None() : base(Null.NULL)
        {

        }
    }
}
