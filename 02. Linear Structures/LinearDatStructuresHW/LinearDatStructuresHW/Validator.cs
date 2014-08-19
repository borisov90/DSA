namespace CalculatingSequence
{
    using System;

    public class Validator
    {
        public static int validateInput(string input)
        {
            int value;

            if (int.TryParse(input, out value))
            {
                return value;
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }
    }
}
