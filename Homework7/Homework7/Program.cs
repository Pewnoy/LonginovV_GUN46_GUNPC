using System;
using System.Text;
namespace HomeWork7
{
    internal class Program
    {
        // Задание 1
        public static string ConcatenateStrings(string first, string second)
        {
            return first + second;
        }

        // Задание 2
        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        // Задание 3
        public static string GetStringInfo(string input)
        {
            return $"Length: {input.Length}\n" +
                   $"Uppercase: {input.ToUpper()}\n" +
                   $"Lowercase: {input.ToLower()}";
        }

        // Задание 4
        public static string GetFirstFiveCharacters(string input)
        {
            return input.Substring(0, 5);
        }

        // Задание 5
        public static StringBuilder BuildSentence(string[] words)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < words.Length; i++)
            {
                builder.Append(words[i]);

                if (i < words.Length - 1)
                {
                    builder.Append(" ");
                }
            }

            return builder;
        }

        // Задание 6
        public static string ReplaceWords(
            string inputString,
            string wordToReplace,
            string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }
    }
}