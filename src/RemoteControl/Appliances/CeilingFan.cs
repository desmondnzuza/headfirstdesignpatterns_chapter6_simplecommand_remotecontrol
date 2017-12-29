using System;

namespace RemoteControl.Appliances
{
    public class CeilingFan
    {

        public void High()
        {
            Console.WriteLine("CeilingFan set to high");
        }

        public void Medium()
        {
            Console.WriteLine("CeilingFan set to medium");
        }

        public void Low()
        {
            Console.WriteLine("CeilingFan set to low");
        }

        public void off()
        {
            Console.WriteLine("CeilingFan off");
        }

        public void GetSpeed()
        {
            Console.WriteLine("CeilingFan is fetching speed");
        }
    }
}
