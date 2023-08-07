namespace Rover.Interfaces
{
    interface ICollidable
    {
        public int BoundsX { get; set; }
        public int BoundsY { get; set; }

        Dictionary<string, bool> WillCollide(int positionX, int positionY);
    }
}
