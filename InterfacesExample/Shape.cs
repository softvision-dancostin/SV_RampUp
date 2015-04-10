using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    public abstract class Shape
    {
        private string _Name;
        private string _PetName;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string PetName
        {
            get { return _PetName; }
            set { _PetName = value; }
        }

        public Shape() { }
        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Draw() { }
    }
}
