using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class StreamReader
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
            // Now read data from file.
            Console.WriteLine("Here are your thoughts:\n");
            using(StreamReader sr = FileInf.OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) ! = null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.ReadLine();
        }
    }
}
