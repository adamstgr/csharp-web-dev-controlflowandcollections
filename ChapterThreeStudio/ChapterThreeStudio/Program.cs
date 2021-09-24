using System;
using System.Collections.Generic;

namespace ChapterThreeStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] charInString = example.ToCharArray();
            Dictionary<char, int> values = new Dictionary<char, int>();
            for (int i = 0; i < charInString.Length; i++)
            {
                if (values.ContainsKey(charInString[i]) == false)
                {
                    values.Add(charInString[i], 1);
                }
                else
                {
                    values[charInString[i]] += 1;
                }
            }
            foreach (KeyValuePair<char, int> entry in values)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
