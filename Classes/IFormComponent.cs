using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public interface IFormComponent
    {
        void SetValue(string value);
        string GetValue();
        string GetName();
    }

}