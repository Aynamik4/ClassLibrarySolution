using System;

namespace MyClassLibrary
{
    public class Utils
    {
        static readonly Random random = new Random();

        /// <summary>
        /// Returns true with a probability of the percent parameter.
        /// </summary>
        /// <param name="percent">The probability value.</param>
        /// <returns></returns>
        public static bool ProbabilityTrue(int percent)
        {
            int randomNumber = random.Next(1, 100 + 1);
            return randomNumber <= percent;
        }
    }
}
