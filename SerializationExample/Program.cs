using System;

namespace SerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");
            // Make a JamesBondCar and set state.
            JamesBondCar jbc = new JamesBondCar();
            jbc.CanFly = true;
            jbc.CanSubmerge = false;
            jbc.TheRadio.StationPresets = new double[] { 89.3, 105.1, 97.1 };
            jbc.TheRadio.HasTweeters = true;

            // Now save the car to a specific file in a binary format.
            BinaryFormatterExample binaryFormatter = new BinaryFormatterExample();
            Console.WriteLine("Saving with Binary Formatter.");
            binaryFormatter.SaveAsBinaryFormat(jbc, "CarData.dat");
            Console.WriteLine("Loading with Binary Formatter.");
            jbc = binaryFormatter.LoadFromBinaryFile("CarData.dat");
            Console.WriteLine("");

            SoapFormatterExample soapFormatter = new SoapFormatterExample();
            Console.WriteLine("Saving with Soap Formatter.");
            soapFormatter.SaveAsSoapFormat(jbc, "CarDataSoap.dat");
            Console.WriteLine("Loading with Soap Formatter.");
            jbc = soapFormatter.LoadFromSoapFile("CarDataSoap.dat");
            Console.WriteLine("");

            XmlSerializerExample xmlFormatter = new XmlSerializerExample();
            Console.WriteLine("Saving with Xml Formatter.");
            xmlFormatter.SaveAsXmlFormat(jbc, "CarDataXml.dat");
            Console.WriteLine("Loading with Xml Formatter.");
            jbc = xmlFormatter.LoadFromXmlFile("CarDataXml.dat");
            Console.ReadLine();
        }


    }
}
