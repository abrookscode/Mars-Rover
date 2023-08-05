namespace Rover
{
    internal class RemoteController : Rotator, IMoveable
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public RemoteController(int positionX, int positionY, string heading) : base(heading)
        {
            PositionX = positionX;
            PositionY = positionY;
            Heading = heading;
        }

        public void Move()
        {
            switch (Heading)
            {
                case "N":
                    PositionY++;
                    break;
                case "S":
                    PositionY--;
                    break;
                case "E":
                    PositionX++;
                    break;
                case "W":
                    PositionX--;
                    break;
                default:
                    break;
            }
        }
    }
}
