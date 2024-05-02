using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_derusting
{
    public static class stringManipulation
    {
        public static Func<string, string> ReverseWordInString = sentence => 
            string.Join(" ", sentence.Split(" ").Reverse());


        public static string ReverseVowelsInString(string sentence)
        {
            char[] vowels = sentence.Where(c => "aeiou".Contains(c)).Reverse().ToArray();

            string[] splitSentence = sentence.Split(vowels);

            string result = splitSentence[0];

            for(int i = 1; i < splitSentence.Length; i++)
            {
                result += vowels[i - 1] + splitSentence[i];
            }

            return result;
        }
    }
}
