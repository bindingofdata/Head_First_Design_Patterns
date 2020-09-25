using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace RemoteControl
{
    public class RemoteControl
    {
        private readonly IUndoableCommand[] onCommands;
        private readonly IUndoableCommand[] offCommands;

        public RemoteControl()
        {
            onCommands = new IUndoableCommand[7];
            offCommands = new IUndoableCommand[7];

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = new CommandNotSet("On", i);
                offCommands[i] = new CommandNotSet("Off", i);
            }
        }

        public void SetCommand(int slot, IUndoableCommand onCommand, IUndoableCommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot].Execute(null);
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute(null);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\n------ Remote Control ------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                builder.Append("[slot ").Append(i).Append("] ").Append(onCommands[i].GetType().Name).Append('\t').AppendLine(offCommands[i].GetType().Name);
            }

            return builder.ToString();
        }
    }
}
