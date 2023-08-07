namespace Rover.Utilities
{
    public class Reader
    {
        public virtual string GetInput()
        {
            var readLine = Console.ReadLine();
            if (readLine == "exit")
            {
                LoopController.Exit = true;
            }
            return string.IsNullOrEmpty(readLine) ? string.Empty : readLine;
        }
    }
}
