using System;

namespace SerializationExample
{
    [Serializable]
    public class Car
    {
        public Car()
        {
            TheRadio = new Radio();
        }

        [System.Xml.Serialization.XmlElement("TheRadio")]
        private Radio theRadio;
        [System.Xml.Serialization.XmlElement("IsHatchBack")]
        private bool isHatchBack;

        public Radio TheRadio
        {
            get { return theRadio; }
            set { theRadio = value; }
        }

        public bool IsHatchBack
        {
            get { return isHatchBack; }
            set { isHatchBack = value; }
        }
    }
}
