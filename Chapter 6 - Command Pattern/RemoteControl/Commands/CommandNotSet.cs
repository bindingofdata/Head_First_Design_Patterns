using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class CommandNotSet : IUndoableCommand
    {
        private readonly int commandSlot;
        private readonly string commandType;
        public CommandNotSet(string commandType, int slotNumber)
        {
            commandSlot = slotNumber;
            this.commandType = commandType;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Console.WriteLine($"No command set for \"{commandType}\" command slot {commandSlot}");
        }

        public void Undo()
        {
            Console.WriteLine($"No command set for \"{commandType}\" command slot {commandSlot}");
        }
    }
}
