using System;
using System.Collections.Generic;

namespace Sixty_Editor_DLL
{
    public interface IMethod
    {
        string Name { get; set; }
        Type Type { get; }
        Type ReturnType { get; }

        List<IExpression> Expressions { get; }

        IExpression Evaluate();
        string Inspect();
    }
}
