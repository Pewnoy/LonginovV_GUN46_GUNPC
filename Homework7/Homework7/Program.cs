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
            return input.Substring(0, Math.Min(5, input.Length));
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
            if (string.IsNullOrEmpty(inputString) ||
                string.IsNullOrEmpty(wordToReplace) ||
                string.IsNullOrEmpty(replacementWord))
            {
                return inputString;
            }

            return inputString.Replace(wordToReplace, replacementWord);
        }
        static void Main(string[] args)
        {
            // Проверка задания 1
            string result1 = ConcatenateStrings("Hello ", "world!");
            Console.WriteLine(result1);

            Console.WriteLine();


            // Проверка задания 2
            string result2 = GreetUser("Victor", 30);
            Console.WriteLine(result2);

            Console.WriteLine();


            // Проверка задания 3
            string result3 = GetStringInfo("Hello World");
            Console.WriteLine(result3);

            Console.WriteLine();


            // Проверка задания 4
            string result4 = GetFirstFiveCharacters("Hello world");
            Console.WriteLine(result4);

            Console.WriteLine();


            // Проверка задания 5
            string[] words = { "CSharp", "is", "interesting" };
            StringBuilder result5 = BuildSentence(words);
            Console.WriteLine(result5);

            Console.WriteLine();


            // Проверка задания 6
            string result6 = ReplaceWords(
                "Hello world",
                "world",
                "universe");

            Console.WriteLine(result6);
        }
    }
}