namespace Rover
{
    public static class Parser
    {
        private static string Input { get; set; } = string.Empty;
        private static string[] Commands { get; set; } = new string[0];
        public static int[] Bounds(string prompt)
        {
            Console.WriteLine(prompt);
            while (true) { if (ValidateBounds()) break; }

            return new int[] { int.Parse(Commands[0]), int.Parse(Commands[1]) };
        }
        public static object[] Location(string prompt)
        {
            Console.WriteLine(prompt);
            while (true) { if (ValidateLocation()) break; }

            return new object[] { int.Parse(Commands[0]), int.Parse(Commands[1]), Commands[2] };
        }
        public static char[] Instructions(string prompt)
        {
            Console.WriteLine(prompt);
            while (true) { if (ValidateEmpty()) break; }
            char[] commands = Input.ToCharArray();

            return commands;
        }

        private static bool ValidateEmpty()
        {
            var buffer = Console.ReadLine();
            if (string.IsNullOrEmpty(buffer))
            {
                Console.WriteLine("Please enter a value and try again.");
                return false;
            }
            Input = buffer;
            Commands = Input.Split();
            return true;
        }
        private static bool ValidateBounds()
        {
            if (ValidateEmpty())
            {
                if (
                    Commands.Length != 2 ||
                    (!int.TryParse(Commands[0], out int val)) ||
                    (!int.TryParse(Commands[1], out int val2))
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

        private static bool ValidateLocation()
        {
            string[] validHeadings = { "N", "S", "E", "W" };
            if (ValidateEmpty())
            {
                if (
                    Commands.Length != 3 ||
                    (!int.TryParse(Commands[0], out int val)) ||
                    (!int.TryParse(Commands[1], out int val2)) ||
                    (int.TryParse(Commands[2], out int val3)) ||
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