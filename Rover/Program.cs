using Rover.Utilities;

namespace Rover
{
    class Program
    {
        static void Main()
        {
            new Bootstrapper(new Reader()).Start();
        }
    }
}
