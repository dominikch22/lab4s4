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
            int counter = 0;
            bool changed = true;
            while (counter < chars.Length) {
                if (" ".Contains(input[counter]))
                {
                    changed = true;
                }
                else { 
                    if(changed)
                        chars[counter] = char.ToUpper(input[counter]);
                    changed = !changed;
                }
                counter++;

            }
           
            return new string(chars);
        }

        public static string EverySecondCharLowercase(this string input)
        {
            char[] chars = input.ToCharArray();
            int counter = 0;
            bool changed = false;
            while (counter < chars.Length)
            {
                if (" ".Contains(input[counter]))
                {
                    changed = false;
                }
                else
                {
                    if (changed)
                        chars[counter] = char.ToLower(input[counter]);
                    changed = !changed;
                }
                counter++;

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


            string[] words = input.Split(new[] { ' ', '.', ',', ';', ':', '!','?'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words) {
                wordsLength.Add(word.Length);
            }
           
            return wordsLength.ToArray();
        }

        public static bool IsSentence(this string input) {
            try
            {
                int letterCounter = 0;
                int markCounter = 0;
                if (!char.IsUpper(input[0]))
                    return false;
                if (!".!?".Contains(input[input.Length-1]))
                    return false;

                for (int i = 0; i < input.Length; i++) {
                    if (char.IsUpper(input[i]))
                        letterCounter++;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (".!?".Contains(input[i]))
                        markCounter++;
                }

                if (letterCounter > 1)
                    return false;
                if (markCounter > 1)
                    return false;

                return true;
            }
            catch {
                return false;
            }
           
        }
    }
}
