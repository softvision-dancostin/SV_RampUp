using System;
using System.IO;
using System.Xml.Serialization;

namespace SerializationExample
{
    public class XmlSerializerExample
    {
        public void SaveAsXmlFormat(object objGraph, string fileName)
        {
            // Save object to a file named CarData.xml in XML format.
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in XML format!");
        }

        public JamesBondCar LoadFromXmlFile(string fileName)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(JamesBondCar));
            // Read the JamesBondCar from the binary file.
            using (Stream fStream = File.OpenRead(fileName))
            {
                try
                {
                    JamesBondCar carFromDisk = (JamesBondCar)xmlFormat.Deserialize(fStream);
                    Console.WriteLine("=> Loaded car in XML format!");
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
