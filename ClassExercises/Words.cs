using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercises
{
    internal class Words
    {
        public static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(" ");
            string longestWord = words[0];

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }

            }
            return longestWord;
        }

        
    }
}
