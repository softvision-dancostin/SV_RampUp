using System;

namespace SerializationExample
{
    [Serializable]
    public class JamesBondCar : Car
    {
        private bool canFly;
        private bool canSubmerge;

        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }

        public bool CanSubmerge
        {
            get { return canSubmerge; }
            set { canSubmerge = value; }
        }
    }
}
