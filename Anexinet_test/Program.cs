using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexinet_test
{
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IAnexinetFunctions anexinetFunctions = new AnexinetFunctions();

            //Exercise #2
            RunAngles(anexinetFunctions);

            //Exercise #3
            //RunIntToRoman(anexinetFunctions);

            //Exercise #4
            //RunIsAnagram(anexinetFunctions);

            //Exercise #5
            //RunStringCompression(anexinetFunctions);

            //Exercise #6
            //RunReverseString(anexinetFunctions);

            //Exercise #7
            //RunIntIsLeapYear(anexinetFunctions);

            //Exercise #8
            //RunChangeToZeroRowAndColumns(anexinetFunctions);
        }

        /// <summary>
        /// Run angles exercise
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunAngles(IAnexinetFunctions anexinetFunctions)
        {
            double hour = 0.0;
            double minutes = 0.0;
            string error = string.Empty;

            Console.WriteLine("Enter a time to compute angle\n");
            Console.WriteLine("Enter Hour Clock Hand Value");
            
            try
            {
                hour = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("\nEnter Minute Clock Hand Value");
            try
            {
                minutes = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            returnArguments returnArguments = anexinetFunctions.GetAngleBetweenClockHands(hour, minutes);
            Console.WriteLine(string.Format("\n{0}{1}\n", returnArguments.Message, returnArguments.Value));

            RunAngles(anexinetFunctions);
           
        }

        /// <summary>
        /// Runs int to roman numeral exercise
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunIntToRoman(IAnexinetFunctions anexinetFunctions)
        {
            Console.WriteLine("Enter an integer to convert to roman numeral\n");

            try
            {
                int integerInput = int.Parse(Console.ReadLine());

                returnArguments returnArguments = anexinetFunctions.ConvertIntToRomanNumeral(integerInput);
                Console.WriteLine(string.Format("{0}{1}\n", returnArguments.Message, returnArguments.Value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0}\n",ex.Message));
            }

            RunIntToRoman(anexinetFunctions);
        }

        /// <summary>
        /// Run is anagram exercise
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunIsAnagram(IAnexinetFunctions anexinetFunctions)
        {
            string stringA = string.Empty;
            string stringB = string.Empty;

            Console.WriteLine("Enter strings to test whether one is an anagram of the other\n");
            Console.WriteLine("Enter string A");

            try
            {
                stringA = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("\nEnter string B");
            try
            {
                stringB = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            returnArguments returnArguments = anexinetFunctions.IsAnagram(stringA, stringB);
            Console.WriteLine(string.Format("\n{0}\n", returnArguments.Message));

            RunIsAnagram(anexinetFunctions);
        }

        /// <summary>
        /// Run string compression
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunStringCompression(IAnexinetFunctions anexinetFunctions)
        {
            Console.WriteLine("Enter string to compress\n");

            try
            {
                string stringToCompress = Console.ReadLine();
                
                returnArguments returnArguments = anexinetFunctions.CompressString(stringToCompress);
                Console.WriteLine(string.Format("{0}{1}\n", returnArguments.Message, returnArguments.Value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0}\n", ex.Message));
            }

            RunStringCompression(anexinetFunctions);
        }

        /// <summary>
        /// Run reverse string
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunReverseString(IAnexinetFunctions anexinetFunctions)
        {
            Console.WriteLine("Enter string to be reversed\n");

            try
            {
                string stringToBeReversed = Console.ReadLine();

                returnArguments returnArguments = anexinetFunctions.ReverseString(stringToBeReversed);
                Console.WriteLine(string.Format("{0}{1}\n", returnArguments.Message, returnArguments.Value));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0}\n", ex.Message));
            }

            RunReverseString(anexinetFunctions);
        }

        /// <summary>
        /// Runs int is leap year
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunIntIsLeapYear(IAnexinetFunctions anexinetFunctions)
        {
            Console.WriteLine("Enter an integer to check if it is a leap year:\n");

            try
            {
                int integerInput = int.Parse(Console.ReadLine());

                returnArguments returnArguments = anexinetFunctions.IsLeapYear(integerInput);
                Console.WriteLine(string.Format("{0}\n", returnArguments.Message));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0}\n", ex.Message));
            }

            RunIntIsLeapYear(anexinetFunctions);
        }

        /// <summary>
        /// Run change to zero row and columns
        /// </summary>
        /// <param name="anexinetFunctions"></param>
        static void RunChangeToZeroRowAndColumns(IAnexinetFunctions anexinetFunctions)
        {
            int[,] exampleArray = new int [,] {
                { 1, 2, 3 }, 
                { 4, 0, 6 }, 
                { 7, 8, 9 }
            };

            returnArguments returnArguments = anexinetFunctions.ChangeToZeroRowAndColumns(exampleArray);
            Console.WriteLine(string.Format("{0}\n", returnArguments.Message));
            Console.ReadKey();

            RunChangeToZeroRowAndColumns(anexinetFunctions);
        }
    }
}
