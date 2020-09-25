using System;

namespace RemoteControl
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            // create devices
            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo("Living Room");

            // light commands
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            // fan commands
            CeilingFanOnOrChangeSpeedCommand ceilingFanOn = new CeilingFanOnOrChangeSpeedCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            // garage commands
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            // stereo commands
            StereoOnToCDCommand stereoOn = new StereoOnToCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            // assign commands to slots
            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remote.SetCommand(3, stereoOn, stereoOff);

            // print current remote state
            Console.WriteLine(remote);

            // test button presses
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);
        }
    }
}
