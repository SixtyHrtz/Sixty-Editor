using System.Collections.Generic;

namespace Sixty_Editor_DLL
{
    public abstract class Expression<T> : IExpression
    {
        private IMethod method;

        private ExpressionType expressionType;

        private List<IConstantInfo> constants;
        private List<IMethodInfo> methods;

        public string Name { get; set; }
        public T Value { get; set; }
        public abstract string BaseValue { get; set; }
        public IMethod Method
        {
            get { return method; }
            set { method = value; }
        }

        public ExpressionType ExpressionType
        {
            get { return expressionType; }
            set { expressionType = value; }
        }
        public abstract ExpressionType AllowedExpressionType { get; }

        public IConstantInfo[] Constants { get { return constants.ToArray(); } }
        public IMethodInfo[] Methods { get { return methods.ToArray(); } }

        public Expression(T value) : this(value, "")
        {

        }

        public Expression(T value, string name)
        {
            BaseValue = value.ToString();
            Name = name;

            constants = new List<IConstantInfo>();
            methods = new List<IMethodInfo>();

            SetDefaultExpressionType();
        }

        private void SetDefaultExpressionType()
        {
            if (AllowedExpressionType.HasFlag(ExpressionType.Value))
                ExpressionType = ExpressionType.Value;
            else if (AllowedExpressionType.HasFlag(ExpressionType.Constant))
                ExpressionType = ExpressionType.Constant;
            else if (AllowedExpressionType == ExpressionType.Method)
                ExpressionType = ExpressionType.Method;
        }

        protected void AddConstant(IConstantInfo constantInfo)
        {
            constants.Add(constantInfo);
        }

        protected void AddMethod(IMethodInfo methodInfo)
        {
            methods.Add(methodInfo);
        }

        public IExpression Evaluate()
        {
            switch (expressionType)
            {
                case ExpressionType.Constant:
                case ExpressionType.Value:
                    return this;
                case ExpressionType.Method:
                    return method.Evaluate();
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
                case ExpressionType.Method:
                    return method.Inspect();
            }

            return "null";
        }
    }
}
