using System;
using System.Text.RegularExpressions;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string str)
        {
            // string noPuntuation = Regex.Replace(str, @"[^\w\s]", string.Empty);
            // char[] delimiterChars = { ' ', '!', ',', '.', ':', '\t' };
            string[] words = str.Split(' ');
            string[] sentence = new String[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                if (Regex.IsMatch(words[i], @"^[A-Za-z]+$"))
                {
                    sentence[i] = words[i].Substring(1) + words[i][0] + "ay";
                    Console.WriteLine(sentence[i]);

                }
                else
                {
                    sentence[i] = words[i];
                }

            }

            return string.Join(" ", sentence);
        }
    }
}

