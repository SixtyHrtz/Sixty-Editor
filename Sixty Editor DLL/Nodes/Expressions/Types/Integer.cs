namespace Sixty_Editor_DLL
{
    public class Integer : Expression<int>
    {
        public override ExpressionType AllowedExpressionType
        {
            get { return ExpressionType.Constant | ExpressionType.Value | ExpressionType.Method; }
        }

        public override string BaseValue
        {
            get { return Value.ToString(); }
            set { Value = int.Parse(value); }
        }

        public Integer(int value = 0, string name = "") : base(value, name)
        {
            AddMethod(new MethodInfo<Arithmetic>("Арифметика"));
            AddMethod(new MethodInfo<Abs>("Модуль"));
            AddMethod(new MethodInfo<Min>("Минимум"));
            AddMethod(new MethodInfo<Random>("Случайное"));
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
