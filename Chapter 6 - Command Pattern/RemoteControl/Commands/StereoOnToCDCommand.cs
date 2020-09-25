using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class StereoOnToCDCommand : IUndoableCommand
    {
        private readonly Stereo stereo;

        public StereoOnToCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            stereo.TurnOn();
            stereo.SetCD();
            stereo.SetVolume(11);
        }

        public void Undo()
        {
            stereo.TurnOff();
        }
    }
}
