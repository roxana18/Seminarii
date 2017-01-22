using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    //Exercise 9  top level classes cannot be protected, they must be inner classes
  internal class Mercedes : AbstractCar
    {
        public string description;
        public int price;
        private string _description;
        private int _price;

        public Mercedes()
        {
            description = "E Class";
            price = 67000;
        }
        //If the properties are protected they are inaccessible for Program.cs

        internal string Description
        {
            get { return _description; }
            set { _description = value + "property Description"; }
        }

        internal int Price
        {
            get { return _price; }
            set { _price = value + 50000; }
        }
    }
}
