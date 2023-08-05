namespace Rover
{
    public abstract class Compass
    {
        private int _degree;
        private string _heading = string.Empty;
        protected string Heading
        {
            get
            {
                return _heading;
            }
            set
            {
                _heading = value;
                _degree = _cardinalReverse[value];
            }
        }
        protected int Degree
        {
            get
            {
                return _degree;
            }
            set
            {
                _degree = value;
                _heading = _cardinal[value];
            }
        }

        private Dictionary<int, string> _cardinal = new Dictionary<int, string>()
        {
            { 0, "N" },
            { 90, "E" },
            { 180, "S" },
            { 270, "W" },
        };

        private Dictionary<string, int> _cardinalReverse = new Dictionary<string, int>()
        {
            { "N", 0 },
            { "E", 90 },
            { "S", 180 },
            { "W", 270 },
        };

        public Compass(string heading)
        {
            Heading = heading;
        }

        protected int Calculate(int degree)
        {
            return degree < 0 ? 360 + (degree % 360) : degree % 360;
        }
    }
}
