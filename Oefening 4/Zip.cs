using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    class Zip
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World");
            string path = @"D:\NET\Tutorial\Data\DirFileOefening";
            string extractPath = @"D:\.NET\Tutorial\Data\DirFileOefening\extract";
            string zipPath = @"D:\.NET\Tutorial\Data\DirFileOefening\DirFileOefening.zip";

            CreateZipFile(zipPath, Directory.EnumerateFiles(path, "*.csv"));
            File.Copy(zipPath, Path.Combine(path, "copyOfZip.zip"));
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
        public static void CreateZipFile(string fileName, IEnumerable<string> files)
        {
            // Create and open a new ZIP file
            var zip = ZipFile.Open(fileName, ZipArchiveMode.Create);
            foreach (var file in files)
            {
                // Add the entry for each file
                zip.CreateEntryFromFile(file, Path.GetFileName(file), CompressionLevel.Optimal);
            }
            zip.Dispose();
        }
    }
}