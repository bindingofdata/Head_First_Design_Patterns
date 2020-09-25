using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class CeilingFanOnOrChangeSpeedCommand : IUndoableCommand
    {
        private readonly CeilingFan fan;

        public CeilingFanOnOrChangeSpeedCommand(CeilingFan ceilingFan)
        {
            fan = ceilingFan;
            fan.ToggleCount = 0;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (fan.CurrentSpeed == 0)
            {
                fan.TurnOn();
            }
            else
            {
                fan.NextSpeed();
            }
            fan.ToggleCount++;
        }

        public void Undo()
        {
            if (fan.ToggleCount <= 1)
            {
                fan.TurnOff();
                fan.ToggleCount = 0;
            }
            else
            {
                fan.LastSpeed();
                fan.ToggleCount--;
            }
        }
    }
}
