using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class NumberValidator : Decorator
    {
        string value, name;
        public NumberValidator(IFormComponent decorated) : base(decorated) 
        {
            name = _decorated.GetName();
        }

        public override void SetValue(string val)
        {
            _decorated.SetValue(val);
            while (Int32.TryParse(_decorated.GetValue(), out int i) == false)
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
