using System;
using System.Collections.Generic;

namespace Assi3 {
    public class Form 
    {
        private IState _state;
        IFormComponent _formComponent;

        public Form()
        {
        }

        public List<IFormComponent> formComponents = new List<IFormComponent>();

        public void AddComponent(IFormComponent formComponent)
        {

            formComponents.Add(formComponent);
        }

        public void print()
        { 
            foreach(var formComponent in formComponents)
            {
                Console.WriteLine($"{formComponent.GetName()}: {formComponent.GetValue()}");
            }    
        }

        public void ChangeState(IState state)
        {
            _state = state;
        }

        public bool HandleInput(string input)
        {
            switch (input)
            {
                case "Username":
                    _state.Run();  
                    break;
                case "Email":
                    _state.Run();
                    break;
                case "Real Name":
                    _state.Run();
                    break;
                case "Password":
                    _state.Run();
                    break;
                case "Confirm Password":
                    _state.Run();
                    break;
                case "Age":
                    _state.Run();
                    break;
                case "exit":
                    return false;
            }
            return true;
        }


    }
}
