using System;
using RemoteControl.Appliances;
using RemoteControl.Commands;
using RemoteControl.Controllers;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new SimpleRemoteControl();

            var light = new Light();
            var lightOn = new LightOnCommand(light);

            var garageDoor = new GarageDoor();
            var garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
