using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp
{
    /// <summary>
    /// Lottery-class
    /// @author Saara Virtanen
    /// @version 28.2.2016
    /// </summary>
    class Lottery
    {
        private static readonly Random rand = new Random();

        public string generateNumbers()
        {
            // create a list of 39 numbers to pick the lottery numbers from
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 39; i++)
            {
                numbers.Add(i);
            }

            // create an array for the lottery numbers (7)
            int[] lotteryNumbers = new int[7];
            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                // generate a random number
                int number = rand.Next(0, numbers.Count);
                // use number as an index in numbers-list and set that as the value of the current index of lotteryNumbers
                lotteryNumbers[i] = numbers[number];
                // remove number from numbers-list (no duplicates!)
                numbers.RemoveAt(number);
            }
            
            // convert lotteryNumbers to string-array strings, then join them into one string and return it
            string[] strings = new string[lotteryNumbers.Length];
            for (int i = 0; i < lotteryNumbers.Length; i++)
                strings[i] = lotteryNumbers[i].ToString("00");

            string result = string.Join("   ", strings);
            return result;
        }
    }
}
