using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    public class Light
    {
        public string Location { get; set; }

        public Light(string location)
        {
            Location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Location} light turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Location} light turned off.");
        }
    }
}
