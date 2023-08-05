namespace Rover
{
    interface IRotateable
    {
        protected Dictionary<string, int> Rotation { get; set; }

        void Rotate(string direction);
    }
}
