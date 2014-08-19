namespace CountOccurencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Counter
    {
        public static Dictionary<int, int> CountOccurencies(int[] numbers)
        {
            var dictionary = new Dictionary<int, int>();
            var numbersCount = numbers.Length;
            int index;

            numbers = numbers.OrderBy(x => x).ToArray();

            for (index = 0; index < numbersCount; index++)
            {
                if (dictionary.ContainsKey(numbers[index]))
                {
                    dictionary[numbers[index]]++;
                }
                else
                {
                    dictionary.Add(numbers[index], 1);
                }
            }
            return dictionary;
        }
    }
}
