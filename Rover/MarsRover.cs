namespace Rover
{
    internal class MarsRover : Vehicle
    {
        Planet Planet { get; set; }
        public MarsRover(int positionX, int positionY, string heading, Planet planet) : base(positionX, positionY, heading)
        {
            Planet = planet;
        }

        public void Instruct(char[] commands)
        {
            if (commands.Length > 0)
            {
                foreach (char command in commands)
                {
                    switch (command)
                    {
                        case 'L':
                        case 'R':
                            Rotate(command.ToString());
                            break;
                        case 'M':
                            Move();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private new void Move()
        {
            if (Planet.WillCollide(PositionX, PositionY)[Heading] == false)
            {
                base.Move();
            }
        }

        public void Report()
        {
            Console.WriteLine($"{PositionX} {PositionY} {Heading}");
        }
    }
}
