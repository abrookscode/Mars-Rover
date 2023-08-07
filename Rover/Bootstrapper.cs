using Rover.Utilities;
//5 5
//1 2 N
//LMLMLMLMM
//3 3 E
//MMRMMRMRRM
namespace Rover
{
    public class Bootstrapper : Parser
    {
        public Bootstrapper(Reader reader) : base(reader)
        {
        }

        public void Start()
        {
            int[] bounds = Bounds("Define the Bounds for the planet [X Y]: ");
            Planet mars = new Planet(bounds[0], bounds[1]);

            while (!LoopController.Exit)
            {
                object[] location = Location("Define starting position of the Rover [X Y Z]: ");
                char[] instructions = Instructions("Enter instructions: [LRM]: ");

                MarsRover rover = new MarsRover((int)location[0], (int)location[1], (string)location[2], mars);

                rover.Instruct(instructions);
                rover.Report();
            }
        }
    }
}