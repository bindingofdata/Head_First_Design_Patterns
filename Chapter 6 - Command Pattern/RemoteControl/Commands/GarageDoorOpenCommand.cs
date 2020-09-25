using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class GarageDoorOpenCommand : IUndoableCommand
    {
        private readonly GarageDoor door;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            door = garageDoor;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            door.Open();
        }

        public void Undo()
        {
            door.Close();
        }
    }
}
