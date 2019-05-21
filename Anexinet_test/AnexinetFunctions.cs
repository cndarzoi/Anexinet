using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexinet_test
{
    public class AnexinetFunctions : IAnexinetFunctions
    {
        /// <summary>
        /// Gets Angle between clock hands
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minute"></param>
        /// <returns></returns>
        public returnArguments GetAngleBetweenClockHands(double hour, double minute)
        {
            double hourAngle = ((60 * hour) + minute) / 2;
            double minutesAngles = 6 * minute;

            double angle = hourAngle - minutesAngles;

            if (angle < 0)
            {
                angle = angle * -1;
            }

            returnArguments returnArguments = new returnArguments();
            returnArguments.Message = "The angle is: ";
            returnArguments.Value = angle;

            return returnArguments;
        }
        
        /// <summary>
        /// Converts int to roman numeral
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public returnArguments ConvertIntToRomanNumeral(int number)
        {
            returnArguments returnArguments = new returnArguments();

            if ((number < 0) || (number > 3999))
            {
                returnArguments.Message = "Value must be between 1 and 3999";

                return returnArguments;
            }

            if (number < 1)
            {
                returnArguments.Message = "Zero does not apply ;)";

                return returnArguments;
            }

            if (number >= 1000)
            {
                return IntToRomanNumeralHelper(number, "M", 1000);
            }

            if (number >= 900)
            {
                return IntToRomanNumeralHelper(number, "CM", 900);
            }

            if (number >= 500) {

                return IntToRomanNumeralHelper(number, "D", 500);
            }

            if (number >= 400) {
                return IntToRomanNumeralHelper(number, "CD", 400);
            }

            if (number >= 100)
            {
                return IntToRomanNumeralHelper(number, "C", 100);
            }

            if (number >= 90)
            {
                return IntToRomanNumeralHelper(number, "XC", 90);
            }

            if (number >= 50)
            {
                return IntToRomanNumeralHelper(number, "L", 50);
            }

            if (number >= 40)
            {
                return IntToRomanNumeralHelper(number, "XL", 40);
            }

            if (number >= 10)
            {
                return IntToRomanNumeralHelper(number, "X", 10);
            }

            if (number >= 9)
            {
                return IntToRomanNumeralHelper(number, "IX", 9);
            }

            if (number >= 5)
            {
                return IntToRomanNumeralHelper(number, "V", 5);
            }

            if (number >= 4)
            {
                return IntToRomanNumeralHelper(number, "IV", 4);
            }

            if (number >= 1)
            {
                return IntToRomanNumeralHelper(number, "I", 1);
            }

            return returnArguments;
        }

        /// <summary>
        /// Test whether stringA is an anagram of stringB 
        /// </summary>
        /// <param name="stringA"></param>
        /// <param name="stringB"></param>
        /// <returns></returns>
        public returnArguments IsAnagram(string stringA, string stringB)
        {
            returnArguments returnArguments = new returnArguments();

            if (stringA.Length != stringB.Length)
            { 
                returnArguments.Message = "Not an Anagram";
                returnArguments.Value = false;
                return returnArguments;
            }
            if (stringA == stringB)
            {
                returnArguments.Message = "Yes, It's an Anagram";
                returnArguments.Value = true;
                return returnArguments;
            }

            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach (char element in stringA.ToCharArray())
            {
                if (dictionary.ContainsKey(element))
                    dictionary[element]++;
                else
                    dictionary.Add(element, 1);
            }
            foreach (char element in stringB.ToCharArray())
            {
                if (!dictionary.ContainsKey(element))
                {
                    returnArguments.Message = "Not an Anagram";
                    returnArguments.Value = false;
                    return returnArguments;
                }
                if (--dictionary[element] == 0)
                {
                    dictionary.Remove(element);
                }
            }

            returnArguments.Message = "Yes, It's an Anagram";
            returnArguments.Value = dictionary.Count == 0;
            return returnArguments;
            
        }

        /// <summary>
        /// Compress a string by using repeated characters count
        /// </summary>
        /// <param name="stringToBeCompressed"></param>
        /// <returns></returns>
        public returnArguments CompressString(string stringToBeCompressed)
        {
            returnArguments returnArguments = new returnArguments();

            List<char> originalList = new List<char>();
            List<string> CompressedList = new List<string>();
            StringBuilder builder = new StringBuilder();

            char[] charArray = originalList.ToArray();

            char character;

            string originalString = "aabcccccaaa";

            originalList.AddRange(originalString);

            charArray = originalList.ToArray();
            
            int i = 0;
            int len = charArray.Length;

            while (i < len)
            {
                int n = 0;
                character = (charArray[i]);
                while (i < charArray.Length && charArray[i] == character)
                {
                    n = n + 1;
                    i++;
                }

                builder.Append(character.ToString());

                if (n >= 1)
                {
                    builder.Append(n.ToString());
                }
            }
            
            returnArguments.Message = "Compression done: ";
            returnArguments.Value = builder.ToString();
            return returnArguments;
        }


        /// <summary>
        /// Reverse a string
        /// </summary>
        /// <param name="stringToBeReversed"></param>
        /// <returns></returns>
        public returnArguments ReverseString(string stringToBeReversed)
        {
            returnArguments returnArguments = new returnArguments();

            string reversed = string.Empty;
            int length = stringToBeReversed.Length - 1;

            while (length >= 0)
            {
                reversed = reversed + stringToBeReversed[length];
                length--;
            }
            
            returnArguments.Message = "Reversed word is: ";
            returnArguments.Value = reversed;

            return returnArguments;
        }

        /// <summary>
        /// Check if a year is a leap year 
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public returnArguments IsLeapYear(int year)
        {
            returnArguments returnArguments = new returnArguments();
            
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                returnArguments.Message = "Yes , It's a Leap year";
                returnArguments.Value = true;
            }
            else
            {
                returnArguments.Message = "No , It's not a Leap year";
                returnArguments.Value = false;
            }

            return returnArguments;
        }

        /// <summary>
        /// Changes to zero row and column when a zero is found
        /// </summary>
        /// <param name="arrayToConvert"></param>
        /// <returns></returns>
        public returnArguments ChangeToZeroRowAndColumns(int[,] arrayToConvert)
        {
            returnArguments returnArguments = new returnArguments();

            int val;
            int[,] temporalArray = new int[,] { };
            int temporalM = 0;
            int temporalN = 0;

            bool zeroFound = false;

            for (int m = 0; m < 3; m++)
            {
                if (zeroFound)
                    break;
                for (int n = 0; n < 3; n++)
                {
                    val = arrayToConvert[m, n];
                    if (val == 0)
                    {
                        temporalArray = arrayToConvert;
                        temporalM = m;
                        temporalN = n;
                        zeroFound = true;
                        break;
                    }
                }
            }

            StringBuilder builder = new StringBuilder();

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    if (m == temporalM)
                    {
                        temporalArray[m, n] = 0;
                    }

                    if (n == temporalN)
                    {
                        temporalArray[m, n] = 0;
                    }
                    builder.Append(string.Format("{0}", temporalArray[m, n]));
                }
                builder.Append(string.Format("\n"));
            }


            returnArguments.Message = builder.ToString();
            returnArguments.Value = temporalArray;

            return returnArguments;
        }

        /// <summary>
        /// Int to roman numeral helper
        /// </summary>
        /// <param name="number"></param>
        /// <param name="letterToConcat"></param>
        /// <param name="substract"></param>
        /// <returns></returns>
        private returnArguments IntToRomanNumeralHelper(int number, string letterToConcat, int substract)
        {
            returnArguments returnArguments = new returnArguments();

            string romanConcat = (string)ConvertIntToRomanNumeral(number - substract).Value;
            returnArguments.Message = "\nThe roman number is: ";
            returnArguments.Value = string.Format("{0}{1}", letterToConcat, romanConcat);

            return returnArguments;
        }
    }
}
