using System;
using System.Collections.Generic;
using System.Text;

namespace Assi3
{
    public class DoneState : IState
    {
        protected StateContext _contextStateDone;

        public DoneState(StateContext contextState)
        {
            _contextStateDone = contextState;
            Run();
        }


        public void Run()
        {
            string choice;
            var form = _contextStateDone.GetForm();
            Console.WriteLine();
            Console.WriteLine("You're done! To confirm, here's what you wrote");
            Console.WriteLine();
            form.print();
            Console.WriteLine();
            Console.WriteLine("Type reset to reset, or ok to proceed.");
            do
            {
                Console.Write("> ");
                choice = Console.ReadLine().ToLower();
            }
            while (choice != "reset" && choice != "ok");

            if (choice == "reset")
            {
                Console.WriteLine();
                form.ChangeState(new InputState(_contextStateDone));
            }
            else if (choice == "ok")
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Type print to print the form, or exit to leave.");
                    Console.Write("> ");
                    choice = Console.ReadLine().ToLower();
                    if (choice == "print")
                    {
                        Console.WriteLine();
                        form.print();
                    }
                } while (choice != "exit");
            }
        }
    }
}
