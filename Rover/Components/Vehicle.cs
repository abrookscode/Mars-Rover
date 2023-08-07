using Rover.Interfaces;

namespace Rover.Components
{
    public abstract class Vehicle : RemoteController, IMoveable, IRotateable
    {
        public int BoundsX { get; set; }
        public int BoundsY { get; set; }

        public Vehicle(int positionX, int positionY, string heading) : base(positionX, positionY, heading)
        {
        }
    }
}
