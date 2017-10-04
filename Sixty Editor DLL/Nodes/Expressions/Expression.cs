using System.Collections.Generic;

namespace Sixty_Editor_DLL
{
    public abstract class Expression<T> : IExpression
    {
        private IFunction function;

        private ExpressionType expressionType;

        private List<IConstantInfo> constants;
        private List<IFunctionInfo> functions;

        public string Name { get; set; }
        public T Value { get; set; }
        public abstract string BaseValue { get; set; }
        public IFunction Function
        {
            get { return function; }
            set { function = value; }
        }

        public ExpressionType ExpressionType
        {
            get { return expressionType; }
            set { expressionType = value; }
        }
        public abstract ExpressionType AllowedExpressionType { get; }

        public IConstantInfo[] Constants { get { return constants.ToArray(); } }
        public IFunctionInfo[] Functions { get { return functions.ToArray(); } }

        public Expression(T value) : this(value, "")
        {

        }

        public Expression(T value, string name)
        {
            BaseValue = value.ToString();
            Name = name;

            constants = new List<IConstantInfo>();
            functions = new List<IFunctionInfo>();

            SetDefaultExpressionType();
        }

        private void SetDefaultExpressionType()
        {
            if (AllowedExpressionType.HasFlag(ExpressionType.Value))
                ExpressionType = ExpressionType.Value;
            else if (AllowedExpressionType.HasFlag(ExpressionType.Constant))
                ExpressionType = ExpressionType.Constant;
            else if (AllowedExpressionType == ExpressionType.Function)
                ExpressionType = ExpressionType.Function;
        }

        protected void AddConstant(IConstantInfo constantInfo)
        {
            constants.Add(constantInfo);
        }

        protected void AddFunction(IFunctionInfo functionInfo)
        {
            functions.Add(functionInfo);
        }

        public IExpression Evaluate()
        {
            switch (expressionType)
            {
                case ExpressionType.Constant:
                case ExpressionType.Value:
                    return this;
                case ExpressionType.Function:
                    return function.Evaluate();
                default:
                    return null;
            }
        }

        public override string ToString()
        {
            switch (expressionType)
            {
                case ExpressionType.Constant:
                case ExpressionType.Value:
                    return BaseValue;
                case ExpressionType.Function:
                    return function.Inspect();
            }

            return "null";
        }
    }
}
