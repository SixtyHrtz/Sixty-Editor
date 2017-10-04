namespace Sixty_Editor_DLL
{
    public class Operator : Expression<string>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.Constant; }
        }

        public override string BaseValue
        {
            get { return Value; }
            set { Value = value; }
        }

        public Operator() : this("")
        {

        }

        public Operator(string value = "", string name = "") : base(value, name)
        {
            AddConstant(new ConstantInfo<Operator>("+", "+"));
            AddConstant(new ConstantInfo<Operator>("-", "-"));
            AddConstant(new ConstantInfo<Operator>("*", "*"));
            AddConstant(new ConstantInfo<Operator>("/", "/"));
            AddConstant(new ConstantInfo<Operator>("%", "%"));
        }

        public static implicit operator Operator(string value)
        {
            return new Operator(value);
        }

        public static implicit operator string(Operator value)
        {
            return ((Operator)value.Evaluate()).Value;
        }
    }
}
