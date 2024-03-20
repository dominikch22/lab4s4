using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4s4
{
    public static class StringExtension
    {
        public static string EverySecondCharUppercase(this string input) {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < input.Length; i++) { 
                if (i % 2 == 0)
                    chars[i] = char.ToUpper(input[i]);
            }
            return new string(chars);
        }

        public static string EverySecondCharLowercase(this string input)
        {
            char[] chars = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    chars[i] = char.ToLower(input[i]);
            }
            return new string(chars);
        }

        public static string DeleteVowels(this string input) {
            StringBuilder builder = new StringBuilder(input);
            int counter = 0;
            while(counter < builder.Length) {
                if ("AEIOUaeiou".Contains(builder[counter]))
                    builder.Remove(counter, 1);
                else
                    counter++;
            }
           
            return builder.ToString();
        }

        public static int[] WordsLength(this string input) {
            List<int> wordsLength = new List<int>();


            string[] words = input.Split(new[] { ' ', '.', ',', ';', ':', '!','?'});
            foreach (string word in words) {
                wordsLength.Add(word.Length);
            }
           
            return wordsLength.ToArray();
        }

        public static bool IsSentence(this string input) {
            try
            {
                if (!char.IsUpper(input[0]))
                    return false;
                if (!".!?".Contains(input[input.Length-1]))
                    return false;

                return true;
            }
            catch {
                return false;
            }
           
        }
    }
}
