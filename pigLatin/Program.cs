using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine();

            string[] separator = { " " };
            string[] strList = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Pig latin translation: ");
            foreach (string str in strList)
            {
                char firstLetter = str[0];
                string data = str.Substring(1)+firstLetter+"ay";
                Console.Write("{0} ", data);
            }

        }
    }
}