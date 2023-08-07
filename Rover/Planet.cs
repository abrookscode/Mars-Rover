using Rover.Interfaces;

namespace Rover
{
    public class Planet : ICollidable
    {
        public int BoundsX { get; set; }
        public int BoundsY { get; set; }
        public int OriginX { get; set; } = 0;
        public int OriginY { get; set; } = 0;

        public Planet(int boundsX, int boundsY)
        {
            BoundsX = boundsX;
            BoundsY = boundsY;
        }

        public Dictionary<string, bool> WillCollide(int PositionX, int PositionY)
        {
            return new Dictionary<string, bool>()
            {
                { "N", BoundsY == PositionY },
                { "E", BoundsX == PositionX },
                { "S", OriginX == PositionY },
                { "W", OriginY == PositionX },
            };
        }
    }
}
