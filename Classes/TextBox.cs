using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class TextBox : IFormComponent
    {
        string name;
        string value;

        public TextBox(string input)
        {
            /*Console.WriteLine($"{input}:");
            Console.Write("> ");
            
            SetValue();*/
            name = input;
        }

        public string GetValue()
        {
            return value;
        }

        public void SetValue(string val)
        {
            value = val;
        }

        public string GetName()
        {
            return name;
        }
    }
}
