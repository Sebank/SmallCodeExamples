using System.Reflection.Metadata;

namespace Basic_derusting
{
    public static class stringManipulation
    {
        public static Func<string, string> ReverseWordInString = sentence => {
            return string.Join(" ", sentence.Split(" ").Reverse());
        };


        public static string ReverseVowelsInString(string sentence)
        {
            char[] vowels = sentence.Where(c => "aeiou".Contains(c)).Reverse().ToArray();

            string[] splitSentence = sentence.Split(vowels);

            string result = splitSentence[0];

            for (int i = 1; i < splitSentence.Length; i++)
            {
                result += vowels[i - 1] + splitSentence[i];
            }

            return result;
        }

        public static string LongestCommonSequence(string sentence0, string sentence1) {
            bool swap = sentence0.Length <= sentence1.Length;

            /* Logic is that we would preffer to iterate the smaller element
                There are edgecases this could benefit, but is it worth the investment?
                Note that this increases memory usage and in most cases will slow down the function
                TODO: Evaluate this */
            if (swap)
            {
                (sentence0, sentence1) = (sentence1, sentence0);
            }

            string[] snippets = new string[sentence0.Length];
            int j;
            for (int i = 0; i < sentence0.Length; i++)
            {
                // check if current element has previously been included
                j = (i > 0 && snippets[i - 1].Length > 1) ? snippets[i - 1].Length - 1 : 1;

                // find longest sequence given previously included elements
                snippets[i] = sentence0.Substring(i, j);
                while (i + j < sentence0.Length && sentence1.Contains(snippets[i]))
                {
                    j++;
                    snippets[i] = sentence0.Substring(i, j);
                }

                // if last element is not part of sequence, remove
                if (!sentence1.Contains(snippets[i]))
                    snippets[i] = sentence0.Substring(i, j - 1);
            }

            return snippets.OrderByDescending(s => s.Length).First();
        }

        public static string GreatestCommonSequenceInString(string sentence0, string sentence1)
        {
            string longestCommonSequence = LongestCommonSequence(sentence0, sentence1);

            // check if longest sequence contains a smaller repeated sequence
            int j = 0;
            string result = longestCommonSequence.ElementAt(j).ToString();

            while ( longestCommonSequence.Substring(j).Contains(result))
            {
                j++;
                result += longestCommonSequence.ElementAt(j);
            }

            return longestCommonSequence.Substring(0, j);
        }
    }
}
