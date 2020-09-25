using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class LightOffCommand : IUndoableCommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
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
            light.TurnOff();
        }

        public void Undo()
        {
            light.TurnOn();
        }
    }
}
