using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationExample
{
    public class BinaryFormatterExample
    {
        public void SaveAsBinaryFormat(object objGraph, string fileName)
        {
            // Save object to a file named CarData.dat in binary.
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in binary format!");
        }

        public JamesBondCar LoadFromBinaryFile(string fileName)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            // Read the JamesBondCar from the binary file.
            using (Stream fStream = File.OpenRead(fileName))
            {
                try
                {
                    JamesBondCar carFromDisk = (JamesBondCar)binFormat.Deserialize(fStream);
                    Console.WriteLine("=> Loaded car in binary format!");
                    return carFromDisk;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
