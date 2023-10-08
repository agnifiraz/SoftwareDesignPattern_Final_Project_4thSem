using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class CharacterValidator : Decorator
    {
        string _character, value, name;
        IFormComponent _formComponent;
        public CharacterValidator(IFormComponent decorated, string character) : base(decorated)
        { 
            _character = character;
            _formComponent = decorated;
            name = _decorated.GetName();
        }

        public override void SetValue(string val)
        {
            _decorated.SetValue(val);
            while (_decorated.GetValue().Contains(_character) == false)
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
