namespace Rover
{
    public class Planet : ICollidable
    {
        public int BoundsX { get; set; }
        public int BoundsY { get; set; }

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
                { "S", 0 == PositionY },
                { "W", 0 == PositionX },
            };
        }
    }
}
