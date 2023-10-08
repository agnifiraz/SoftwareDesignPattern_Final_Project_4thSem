using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class MinLengthValidator : Decorator
    {
        int _length;
        string value, name;
        IFormComponent _formComponent;
        public MinLengthValidator(IFormComponent decorated, int length) : base(decorated)
        {
            _length = length;
            _formComponent = decorated;
            name = _decorated.GetName();
        }

        public override void SetValue(string val)
        {
            _decorated.SetValue(val);
            while (_decorated.GetValue().Length < _length)
            {
                Console.WriteLine("Invalid entry, try again");
                Console.Write("> ");
                string x = Console.ReadLine();
                _decorated.SetValue(x);
            }
            
            value = _decorated.GetValue();
            name = _decorated.GetName();
        }

        public override string GetValue()
        {
            return value;
        }

        public override string GetName()
        {
            return name;
        }
    }
}
