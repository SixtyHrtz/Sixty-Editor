using System;

namespace Sixty_Editor_DLL
{
    public abstract class Function<T> : Method, IFunction
    {
        public Type ReturnType { get { return typeof(T); } }

        public abstract IExpression Evaluate();
    }
}
