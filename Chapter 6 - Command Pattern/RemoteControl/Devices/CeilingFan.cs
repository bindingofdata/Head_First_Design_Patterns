using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    public class CeilingFan
    {
        public string Location { get; set; }
        public int CurrentSpeed { get; set; }
        public int ToggleCount { get; set; }

        public CeilingFan(string location)
        {
            Location = location;
            CurrentSpeed = 0;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Location} ceiling fan turned on.");
            CurrentSpeed = 1;
        }

        public void NextSpeed()
        {
            if (CurrentSpeed >= 3)
            {
                CurrentSpeed = 1;
            }
            else
            {
                CurrentSpeed++;
            }
        }

        public void LastSpeed()
        {
            if (CurrentSpeed <= 1)
            {
                CurrentSpeed = 3;
            }
            else
            {
                CurrentSpeed--;
            }
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Location} ceiling fan turned off.");
            CurrentSpeed = 0;
        }
    }
}
