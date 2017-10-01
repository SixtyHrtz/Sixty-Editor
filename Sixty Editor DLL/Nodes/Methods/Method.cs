using System;
using System.Collections.Generic;

namespace Sixty_Editor_DLL
{
    public abstract class Method<T> : IMethod
    {
        private Dictionary<string, IExpression> expressions;

        public string Name { get; set; }
        public Type Type { get { return GetType(); } }
        public Type ReturnType { get { return typeof(T); } }

        public List<IExpression> Expressions
        {
            get { return new List<IExpression>(expressions.Values); }
        }

        public abstract string Template { get; }

        protected Method()
        {
            expressions = new Dictionary<string, IExpression>();
        }

        public abstract IExpression Evaluate();

        protected void SetExpressions(params IExpression[] expressions)
        {
            this.expressions.Clear();
            foreach (IExpression expression in expressions)
                this.expressions[expression.Name] = expression;
        }

        public string Inspect()
        {
            string output = Template;
            foreach (IExpression expression in expressions.Values)
                output = output.Replace("@" + expression.Name, expression.ToString());

            return output;
        }

        public override string ToString()
        {
            return Inspect();
        }
    }
}
