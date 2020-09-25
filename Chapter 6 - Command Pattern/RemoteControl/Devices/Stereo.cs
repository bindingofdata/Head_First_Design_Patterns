using System;
using System.Collections.Generic;
using System.Text;

namespace RemoteControl
{
    public class Stereo
    {
        public string Location { get; set; }

        public Stereo(string location)
        {
            Location = location;
        }

        public void TurnOn()
        {
            Console.WriteLine($"{Location} stereo turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"{Location} stereo turned off.");
        }

        public void SetCD()
        {
            Console.WriteLine($"{Location} stereo set to CD input.");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{Location} stereo set to DvD input.");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{Location} stereo set to Radio input.");
        }

        public void SetVolume(int volumeLevel)
        {
            Console.WriteLine($"{Location} volume set to {volumeLevel}.");
        }
    }
}
