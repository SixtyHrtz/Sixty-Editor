namespace Sixty_Editor_DLL
{
    public class Boolean : Expression<bool>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.Constant | ExpressionType.Function | ExpressionType.Value; }
        }

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = bool.Parse(value); }
        }

        public Boolean(bool value = false, string name = "") : base(value, name)
        {
            AddFunction(new FunctionInfo<And>("And"));
        }

        public static implicit operator Boolean(bool value)
        {
            return new Boolean(value);
        }

        public static implicit operator bool(Boolean value)
        {
            return ((Boolean)value.Evaluate()).Value;
        }
    }
}
