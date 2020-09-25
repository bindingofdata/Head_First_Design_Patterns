using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class CeilingFanOffCommand : IUndoableCommand
    {
        private readonly CeilingFan fan;
        private int lastToggleCount;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            fan = ceilingFan;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            fan.TurnOff();
            lastToggleCount = fan.ToggleCount;
            fan.ToggleCount = 0;
        }

        public void Undo()
        {
            fan.TurnOn();
            fan.ToggleCount = lastToggleCount;
        }
    }
}
