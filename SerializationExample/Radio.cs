using System;

namespace SerializationExample
{
    [Serializable]
    public class Radio
    {
        [System.Xml.Serialization.XmlElement("HasTweeters")]
        private bool hasTweeters;
        [System.Xml.Serialization.XmlElement("HasSubWoofers")]
        private bool hasSubWoofers;
        [System.Xml.Serialization.XmlElement("StationPresets")]
        private double[] stationPresets;
        [NonSerialized]
        private string radioID = "XF-552RR6";

        public bool HasTweeters
        {
            get { return hasTweeters; }
            set { hasTweeters = value; }
        }

        public bool HasSubWoofers
        {
            get { return hasSubWoofers; }
            set { hasSubWoofers = value; }
        }

        public double[] StationPresets
        {
            get { return stationPresets; }
            set { stationPresets = value; }
        }

        public string RadioID
        {
            get { return radioID; }
            set { radioID = value; }
        }
    }
}
