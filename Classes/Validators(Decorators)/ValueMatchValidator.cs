using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class ValueMatchValidator : Decorator
    {
        string value, name;
        IFormComponent _password;
        public ValueMatchValidator(IFormComponent decorated, IFormComponent password) : base(decorated)
        {
            _password = password;
            name = _decorated.GetName();
        }
        public override void SetValue(string val)
        {
            _decorated.SetValue(val);
            while (_decorated.GetValue() != _password.GetValue())
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
