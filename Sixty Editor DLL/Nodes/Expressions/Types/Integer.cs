namespace Sixty_Editor_DLL
{
    public class Integer : Expression<int>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.Constant | ExpressionType.Function | ExpressionType.Value; }
        }

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = int.Parse(value); }
        }

        public Integer(int value = 0, string name = "") : base(value, name)
        {
            AddFunction(new FunctionInfo<Arithmetic>("Arithmetic"));
            AddFunction(new FunctionInfo<StringLength>("String Length"));
            AddFunction(new FunctionInfo<FloatToInteger>("Float To Integer"));
            AddFunction(new FunctionInfo<StringToInteger>("String To Integer"));
            AddFunction(new FunctionInfo<RandomNumber>("Random Number"));
            AddFunction(new FunctionInfo<Min>("Min"));
            AddFunction(new FunctionInfo<Max>("Max"));
            AddFunction(new FunctionInfo<Abs>("Abs"));
            AddFunction(new FunctionInfo<Sign>("Sign"));
        }

        public static implicit operator Integer(int value)
        {
            return new Integer(value);
        }

        public static implicit operator int(Integer value)
        {
            return ((Integer)value.Evaluate()).Value;
        }
    }
}
