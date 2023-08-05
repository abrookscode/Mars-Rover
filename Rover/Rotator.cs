namespace Rover
{
    public abstract class Rotator : Compass, IRotateable
    {
        public Dictionary<string, int> Rotation { get; set; }

        public Rotator(string heading) : base(heading)
        {
            Rotation = new Dictionary<string, int>()
            {
                { "L", -90 },
                { "R", 90 },
            };
        }

        public void Rotate(string direction)
        {
            Degree = Calculate(Degree + Rotation[direction]);
        }
    }
}
