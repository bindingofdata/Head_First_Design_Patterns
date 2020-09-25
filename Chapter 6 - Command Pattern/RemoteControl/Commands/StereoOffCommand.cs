using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class StereoOffCommand : IUndoableCommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
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
            stereo.TurnOff();
        }

        public void Undo()
        {
            stereo.TurnOn();
            stereo.SetCD();
            stereo.SetVolume(11);
        }
    }
}
