using System;
using System.Collections.Generic;
using System.Text;

namespace FileIO
{
    public class DirectoryInf
    {
		public static void Main(String[] args)
        {
            Console.WriteLine("**** Fun with Directory(info) *****\n");
            ShowWindowsDirectoryInfo();
            Console.ReadLine();
        }
		public static void ShowWindowsDirectoryInfo()
        {
            // Dump directory information.
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Console.WriteLine("***** Directory Info *****");
            Console.WriteLine("FullName: {0}", dir.FullName);
            Console.WriteLine("Name: {0}", dir.Name);
            Console.WriteLine("Parent: {0}", dir.Parent);
            Console.WriteLine("Creation: {0}", dir.CreationTime);
            Console.WriteLine("Attributes: {0}", dir.Attributes);
            Console.WriteLine("Root: {0}", dir.Root);
            Console.WriteLine("**************************\n");
        }
		public static void DisplayImageFiles()
        {
            ShowWindowsDirectoryInfo dir = new ShowWindowsDirectoryInfo(@"C:\Windows\Web\Wallpaper");
            // Get all files with a *.jpg extension.
            Filesinfo[] imageFiles = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

            // How many were found?
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);

			//Now print out of info for each file.
			foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Creation: {0}", f.Attributes);
                Console.WriteLine("*************************\n");
            }
        }
		public static void ModifyAppDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo(".");

            // Create \MyFolder of initial directory.
            dir.CreateSubdirectory("MyFolder");

            // Capture returned DirectoryInfo object.
            DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"MyFolder2\Data");

            //Prints path to ..\MyFolder2\Data.
            Console.WriteLine("New Folder is: {0}", myDataFolder);
        }
    }
}
