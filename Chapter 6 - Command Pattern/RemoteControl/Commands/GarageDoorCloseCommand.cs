using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class GarageDoorCloseCommand : IUndoableCommand
    {
        private static GarageDoor door;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
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
            door.Close();
        }

        public void Undo()
        {
            door.Open();
        }
    }
}
