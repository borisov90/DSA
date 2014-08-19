namespace CalculatingSequence
{
    using System;
    using System.Linq;

    public class Reader
    {
        public static string readFromConsole()
        {
            var line = Console.ReadLine();
            return line;
        }
        public static int readIntegeFromConsole()
        {
            var line = Console.ReadLine();
            var lineAsNumber = int.Parse(line);
            return lineAsNumber;
        }
    }
}
