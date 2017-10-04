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
            AddFunction(new FunctionInfo<Arithmetic>("Арифметика"));
            AddFunction(new FunctionInfo<Abs>("Модуль"));
            AddFunction(new FunctionInfo<Min>("Минимум"));
            AddFunction(new FunctionInfo<Random>("Случайное"));
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
