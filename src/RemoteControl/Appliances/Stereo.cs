using System;

namespace RemoteControl.Appliances
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo is on");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is off");
        }

        public void SetCd()
        {
            Console.WriteLine("Stereo swotcjomg to cd mode");
        }

        public void SetDvd()
        {
            Console.WriteLine("Stereo switching to dvd mode");
        }

        public void SetRadio()
        {
            Console.WriteLine("Stereo switching to radio mode");
        }

        public void SetVolume(int newVolume)
        {
            Console.WriteLine($"Stereo setting volume to{newVolume}");
        }
    }
}