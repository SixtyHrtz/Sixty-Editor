using System;

namespace Sixty_Editor_DLL
{
    public interface IFunctionInfo
    {
        string Name { get; }
        Type Type { get; }

        IFunction GetFunction();
    }
}
