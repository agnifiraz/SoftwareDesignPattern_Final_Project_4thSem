using System;

namespace Assi3
{
    public class StateContext {
        private Form form;

        public void Run(Form form) {
            this.form = form;

            // Set your State here & run it
            form.ChangeState(new InputState(this));
        }

        public Form GetForm() {
            return form;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            
            //Create classes that let you execute the following code:
            
            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Username"), 6
                )
            );
            form.AddComponent(
                new CharacterValidator(
                    new CharacterValidator(
                        new TextBox("Email"), "@"
                    ), "."
                )
            );
            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Real Name"), 2
                )
            );

            IFormComponent password = new CharacterValidator(
                new MinLengthValidator(
                    new TextBox("Password"), 8
                ), "!"
            );
            form.AddComponent(password);

            form.AddComponent(
                new ValueMatchValidator(
                    new TextBox("Confirm Password"), password
                )
            );
            form.AddComponent(
                new NumberValidator(
                    new TextBox("Age")
                )
            );
            

            new StateContext().Run(form);
        }
    }
}
