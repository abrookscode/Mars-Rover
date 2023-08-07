namespace Rover.Utilities
{
    public abstract class Parser
    {
        private string Input { get; set; } = string.Empty;
        private string[] Commands { get; set; } = new string[0];
        private Reader Reader { get; set; }

        public Parser(Reader reader)
        {
            Reader = reader;
        }

        public int[] Bounds(string prompt)
        {
            Console.WriteLine(prompt);
            while (!LoopController.Exit) { if (ValidateBounds()) break; }

            return new int[] { int.Parse(Commands[0]), int.Parse(Commands[1]) };
        }

        public object[] Location(string prompt)
        {
            Console.WriteLine(prompt);
            while (!LoopController.Exit) { if (ValidateLocation()) break; }

            return new object[] { int.Parse(Commands[0]), int.Parse(Commands[1]), Commands[2] };
        }

        public char[] Instructions(string prompt)
        {
            Console.WriteLine(prompt);
            while (!LoopController.Exit) { if (ValidateEmpty()) break; }
            char[] commands = Input.ToCharArray();

            return commands;
        }

        private bool ValidateEmpty()
        {
            var input = Reader.GetInput();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a value and try again.");
                return false;
            }
            Input = input.Trim();
            Commands = Input.Split();
            return true;
        }

        private bool ValidateBounds()
        {
            if (ValidateEmpty())
            {
                if (
                    Commands.Length != 2 ||
                    !int.TryParse(Commands[0], out int val) ||
                    !int.TryParse(Commands[1], out int val2)
                )
                {
                    Console.WriteLine("One or more of your inputs were incorrectly formatted. Please try again");
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        private bool ValidateLocation()
        {
            string[] validHeadings = { "N", "S", "E", "W" };
            if (ValidateEmpty())
            {
                if (
                    Commands.Length != 3 ||
                    !int.TryParse(Commands[0], out int val) ||
                    !int.TryParse(Commands[1], out int val2) ||
                    int.TryParse(Commands[2], out int val3) ||
                    !validHeadings.Contains(Commands[2])
                )
                {
                    Console.WriteLine("One or more of your inputs were incorrectly formatted. Please try again");
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}