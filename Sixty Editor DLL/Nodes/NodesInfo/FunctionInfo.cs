using System;

namespace Sixty_Editor_DLL
{
    public class FunctionInfo<T> : IFunctionInfo where T : IFunction, new()
    {
        public string Name { get; private set; }
        public Type Type { get; private set; }

        public FunctionInfo(string name)
        {
            Name = name;
            Type = typeof(T);
        }

        public IFunction GetFunction()
        {
            IFunction method = new T()
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
