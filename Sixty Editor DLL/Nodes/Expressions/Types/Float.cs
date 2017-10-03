namespace Sixty_Editor_DLL
{
    public class Float : Expression<float>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.Constant | ExpressionType.Value | ExpressionType.Method; }
        }

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = float.Parse(value); }
        }

        public Float(float value = 0, string name = "") : base(value, name)
        {

        }

        public static implicit operator Float(float value)
        {
            return new Float(value);
        }

        public static implicit operator float(Float value)
        {
            return ((Float)value.Evaluate()).Value;
        }
    }
}
