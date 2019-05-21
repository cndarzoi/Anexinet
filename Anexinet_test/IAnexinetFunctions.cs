using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexinet_test
{
    public interface IAnexinetFunctions
    {
        /// <summary>
        /// Gets Angle between clock hands
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></
        returnArguments GetAngleBetweenClockHands(double hourValue, double minuteValue);

        /// <summary>
        /// Converts int to roman numeral
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        returnArguments ConvertIntToRomanNumeral(int number);

        /// <summary>
        /// Is anagram validation
        /// </summary>
        /// <param name="stringA"></param>
        /// <param name="stringB"></param>
        /// <returns></returns>
        returnArguments IsAnagram(string stringA, string stringB);

        /// <summary>
        /// Compress a string by using repeated characters count
        /// </summary>
        /// <param name="stringToBeCompressed"></param>
        /// <returns></returns>
        returnArguments CompressString(string stringToBeCompressed);

        /// <summary>
        /// Rever a string
        /// </summary>
        /// <param name="stringToBeReversed"></param>
        /// <returns></returns>
        returnArguments ReverseString(string stringToBeReversed);

        /// <summary>
        /// Check any int is a leap year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        returnArguments IsLeapYear(int year);

        /// <summary>
        /// Changes to zero row and column when a zero is found
        /// </summary>
        /// <param name="arrayToConvert"></param>
        /// <returns></returns>
        returnArguments ChangeToZeroRowAndColumns(int[,] arrayToConvert);
    }
}
