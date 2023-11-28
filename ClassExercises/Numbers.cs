using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class Numbers
    {
        public static string CountNumberTypes(int[] integers)
        {
            int positive = 0;
            int negative = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < 0)
                {
                    negative++;
                }

                else
                {
                    positive++;
                }

            }


            string returnString = "Total Positive: " + positive + " Total Negative: " + negative;

            return returnString;
        }

        public static int[] CountNumberTypeArrays(int[] integers)
        {
            int positive = 0;
            int negative = 0;

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] < 0)
                {
                    negative++;
                }

                else
                {
                    positive++;
                }

            }



            int[] result = new int[2];

            result[0] = positive;
            result[1] = negative;

            return result;
        }

        public static double CalculateNumberAverage(int[] inputNumbers)
        {
            string input = Console.ReadLine();
            string[] numberString = input.Split(' ');

            if (numberString.Length > 5)
            {
                return 0;
            }

            int[] numberArray = Array.ConvertAll(numberString, s => int.Parse(s));

            int sum = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                sum += numberArray[i];
            }
            double average = (double)sum / 5;


            return average;
        }
        public static bool DertemineIfOddNumber(int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++ )
            {
                if (numbers[i] % 2 != 0)
                {
                  return true ;
                }
               
            }
           
            return false;
        }
       

    }
}
