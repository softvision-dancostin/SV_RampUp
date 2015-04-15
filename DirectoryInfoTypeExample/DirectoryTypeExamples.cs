using System;
using System.IO;

namespace DirectoryInfoTypeExample
{
    public static class DirectoryTypeExamples
    {
        public static void FunWithDirectoryType()
        {
            // List all drives on current computer.
            string[] drives = Directory.GetLogicalDrives();
            Console.WriteLine("Here are your drives:");
            foreach (string s in drives)
                Console.WriteLine("--> {0} ", s);
            // Delete what was created.
            Console.WriteLine("Press Enter to delete directories");
            Console.ReadLine();
            try
            {
                Directory.Delete(@"C:\MyFolder");
                // The second parameter specifies whether you
                // wish to destroy any subdirectories.
                Directory.Delete(@"C:\MyFolder2", true);
                Console.WriteLine("Directories deleted");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DriverInfo()
        {
            Console.WriteLine("***** Fun with DriveInfo *****\n");
            // Get info regarding all drives.
            DriveInfo[] myDrives = DriveInfo.GetDrives();
            // Now print drive stats.
            foreach (DriveInfo d in myDrives)
            {
                Console.WriteLine("Name: {0}", d.Name);
                Console.WriteLine("Type: {0}", d.DriveType);
                // Check to see whether the drive is mounted.
                if (d.IsReady)
                {
                    Console.WriteLine("Total space: {0}", d.TotalSize);
                    Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
                    Console.WriteLine("Format: {0}", d.DriveFormat);
                    Console.WriteLine("Label: {0}", d.VolumeLabel);
                }
                Console.WriteLine();
            }
        }
    }
}
