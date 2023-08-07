namespace Rover.Interfaces
{
    interface IMoveable
    {
        int PositionX { get; set; }
        int PositionY { get; set; }

        void Move();
    }
}
