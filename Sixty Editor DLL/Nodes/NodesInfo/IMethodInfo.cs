using System;

namespace Sixty_Editor_DLL
{
    public interface IMethodInfo
    {
        string Name { get; }
        Type Type { get; }

        IMethod GetMethod();
    }
}
