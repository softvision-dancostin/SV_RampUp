using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesExample
{
    public sealed class VehicleDescriptionAttribute : System.Attribute
    {

        public VehicleDescriptionAttribute()
        {
        }

        public VehicleDescriptionAttribute(string vehicalDescription)
        {
            Description = vehicalDescription;
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
