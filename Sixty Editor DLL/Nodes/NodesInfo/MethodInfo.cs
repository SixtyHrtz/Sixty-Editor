using System;

namespace Sixty_Editor_DLL
{
    public class MethodInfo<T> : IMethodInfo where T : IMethod, new()
    {
        public string Name { get; private set; }
        public Type Type { get; private set; }

        public MethodInfo(string name)
        {
            Name = name;
            Type = typeof(T);
        }

        public IMethod GetMethod()
        {
            IMethod method = new T()
            {
                Name = Name
            };

            return method;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
