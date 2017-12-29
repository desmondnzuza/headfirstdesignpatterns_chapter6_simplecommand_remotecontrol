using RemoteControl.Appliances;

namespace RemoteControl.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _door;

        public GarageDoorOpenCommand(GarageDoor door)
        {
            _door = door;
        }

        public void Excecute()
        {
            _door.Up();
        }
    }
}
