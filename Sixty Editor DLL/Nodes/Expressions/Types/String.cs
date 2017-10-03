namespace Sixty_Editor_DLL
{
    public class String : Expression<string>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.Constant | ExpressionType.Value | ExpressionType.Method; }
        }

        public override string BaseValue
        {
            get { return Value; }
            set { Value = value; }
        }

        public String(string value = "", string name = "") : base(value, name)
        {

        }

        public static implicit operator String(string value)
        {
            return new String(value);
        }

        public static implicit operator string(String value)
        {
            return ((String)value.Evaluate()).Value;
        }
    }
}
