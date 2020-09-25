using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class LightOnCommand : IUndoableCommand
    {
        private readonly Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            light.TurnOn();
        }

        public void Undo()
        {
            light.TurnOff();
        }
    }
}
