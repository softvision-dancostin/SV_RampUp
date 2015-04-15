using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationExample
{
    public class SoapFormatterExample
    {
        public void SaveAsSoapFormat(object objGraph, string fileName)
        {
            // Save object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in SOAP format!");
        }

        public JamesBondCar LoadFromSoapFile(string fileName)
        {
            SoapFormatter soapFormat = new SoapFormatter();
            // Read the JamesBondCar from the binary file.
            using (Stream fStream = File.OpenRead(fileName))
            {
                try
                {
                    JamesBondCar carFromDisk = (JamesBondCar)soapFormat.Deserialize(fStream);
                    Console.WriteLine("=> Loaded car in SOAP format!");
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
