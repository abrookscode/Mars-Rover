namespace Rover.Interfaces
{
    interface IRotateable
    {
        protected Dictionary<string, int> Rotation { get; set; }

        void Rotate(string direction);
    }
}
