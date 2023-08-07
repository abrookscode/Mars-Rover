namespace Rover.Utilities
{
    public static class LoopController
    {
        private static bool _exit;
        public static bool Exit
        {
            get
            {
                return _exit;
            }
            set
            {
                _exit = value;
                Environment.Exit(0);
            }
        }
    }
}
