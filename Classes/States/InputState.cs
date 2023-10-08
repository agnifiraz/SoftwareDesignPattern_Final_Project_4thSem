using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class InputState : IState
    {
        protected StateContext _contextStateInput;

        public InputState(StateContext contextState)
        {
            _contextStateInput = contextState;
            Run();
            
        }


        public void Run()
        {
            

            var fCps = _contextStateInput.GetForm().formComponents;
            Console.WriteLine($"Welcome to the form");
            foreach (var fCp in fCps)
            {
                Console.WriteLine($"{fCp.GetName()}:");
                Console.Write("> ");
                string input = Console.ReadLine();
                fCp.SetValue(input);
            }
            _contextStateInput.GetForm().ChangeState(new DoneState(_contextStateInput));
        }
    }
    

}
