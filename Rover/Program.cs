namespace Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Parser.Bounds("Define the Bounds for the planet [X Y]: ");
            Planet mars = new Planet(bounds[0], bounds[1]);

            while (true)
            {
                object[] location = Parser.Location("Define starting position of the Rover [X Y Z]: ");
                char[] instructions = Parser.Instructions("Enter instructions: [LRM]: ");

                MarsRover rover = new MarsRover((int)location[0], (int)location[1], (string)location[2], mars);
                rover.Instruct(instructions);
                rover.Report();
            }
        }
    }
}
