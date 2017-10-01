namespace Sixty_Editor_DLL
{
    public class ConstantInfo<T> : IConstantInfo where T : IExpression, new()
    {
        public string Name { get; private set; }
        public string Value { get; private set; }

        public ConstantInfo(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public IExpression GetConstant()
        {
            IExpression expression = new T()
            {
                Name = Name,
                BaseValue = Value
            };

            return expression;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
