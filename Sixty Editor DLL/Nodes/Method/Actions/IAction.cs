using System;
using System.Collections.Generic;

namespace Sixty_Editor_DLL
{
    public interface IAction
    {
        string Name { get; set; }
        Type Type { get; }

        List<IExpression> Expressions { get; }

        void Execute();
        string Inspect();
    }
}
