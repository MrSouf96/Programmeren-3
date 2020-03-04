using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class Recursion
    {
        public static void Main(String[] args)
        {
            FileInfo f = new FileInfo("BinFile.dat");

            // Read the binary data from the stream.
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.ReadLine();
        }
        public static void clearFolder(DirectoryInfo dir)
        {
            Console.WriteLine();
        }
        public static void ClearFolder(string folder)
        {
            Console.WriteLine();
        }
    }
}