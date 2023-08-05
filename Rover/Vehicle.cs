namespace Rover
{
    abstract class Vehicle : RemoteController, IMoveable, IRotateable
    {
        public int BoundsX { get; set; } = 5;
        public int BoundsY { get; set; } = 5;

        public Vehicle(int positionX, int positionY, string heading) : base(positionX, positionY, heading)
        {
        }
    }
}
