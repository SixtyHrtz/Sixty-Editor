﻿using System;

namespace Sixty_Editor_DLL
{
    public class Abs : Method<Integer>
    {
        public override string Template { get { return "Модуль(@A)"; } }

        private Integer a = new Integer(name: "A");

        public Abs()
        {
            SetExpressions(a);
        }

        public override IExpression Evaluate()
        {
            return new Integer(Math.Abs(a));
        }
    }
}