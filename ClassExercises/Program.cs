namespace ClassExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 2, 4, 6, 9 };
           bool outcome = OddNumbers.checkoddNumbers(numbers);
            if (outcome) 
            {
                Console.WriteLine("The array contains an odd number");
            }
            else
            {
                Console.WriteLine("The array does not contain an odd number");
            }*/
            /* int[] integers = { -1, 2, 4, 6, 9, };
             string result = Numbers.CountNumberTypes(integers);

             Console.WriteLine(result);


             int[] result2 = Numbers.CountNumberTypeArrays(integers);
             string returnString = "Total Positive: " + result2[0] + " Total Negative: " + result2[1];

              Console.WriteLine(returnString);*/

            /*int[] inputNumbers = { };
            double outcome = Numbers.CalculateNumberAverage(inputNumbers);

            Console.WriteLine("Average: " + outcome);*/

            /*string sentence = "Learning programming is cool";
             string answer = Words.FindLongestWord(sentence);
             Console.WriteLine("The longest word is " + answer);*/

             int[] list = { 2, 4, 6, 8, 9 };
             bool output = Numbers.DertemineIfOddNumber(list);
             if (output)
             {
                 Console.WriteLine(output + " The array contains an odd number.");

             }
             else
             {
                 Console.WriteLine(output + " The array does not contain an odd number.");
             }

        }
    }

}

