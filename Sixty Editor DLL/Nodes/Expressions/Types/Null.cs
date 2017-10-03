namespace Sixty_Editor_DLL
{
    public class Null : Expression<byte>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.None; }
        }

        public override string BaseValue
        {
            get { return "Null"; }
            set { }
        }

        public Null() : base(0)
        {

        }
    }
}
