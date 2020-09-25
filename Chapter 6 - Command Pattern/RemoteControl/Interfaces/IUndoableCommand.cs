using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public interface IUndoableCommand : ICommand
    {
        void Undo();
    }
}
