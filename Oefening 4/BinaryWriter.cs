using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class BinaryWriter
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(("***** Fun with Binary Writers / Readers *****\n");

            // Open a binary writer for a file.
            FileInfo f = new FileInfo("BinFile.dat");
            using(BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
            {
                // Print out the type of BaseStream.
                // (System.IO.FileStream in ths case).
                Console.WriteLine("Base stream is: {0}", bw.BaseStream);

                // Create some data to save in the file.
                double aDouble = 1234.67;
                int anInt = 34567;
                string aString = "A, B, C";

                // Write the data.
                bw.Write(aDouble);
                bw.Write(anInt);
                bw.Write(aString);
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
