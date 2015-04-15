using System;

namespace DirectoryInfoTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Directory(Info) *****\n");
            DirectoryInfoExamples.ShowWindowsDirectoryInfo();
            DirectoryInfoExamples.DisplayImageFiles();
            DirectoryInfoExamples.ModifyAppDirectory();
            DirectoryTypeExamples.FunWithDirectoryType();
            DirectoryTypeExamples.DriverInfo();
            Console.ReadLine();
        }
    }
}
