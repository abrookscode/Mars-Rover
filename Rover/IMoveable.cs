namespace Rover
{
    interface IMoveable
    {
        int PositionX { get; set; }
        int PositionY { get; set; }

        void Move();
    }
}
