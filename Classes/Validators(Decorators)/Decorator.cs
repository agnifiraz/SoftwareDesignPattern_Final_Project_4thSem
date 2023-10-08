using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public abstract class Decorator : IFormComponent
    {
        

        protected IFormComponent _decorated;

        public Decorator(IFormComponent decorated)
        {
            _decorated = decorated;
        }
        public abstract void SetValue(string value);

        public abstract string GetValue();

        public abstract string GetName();

    }
}
