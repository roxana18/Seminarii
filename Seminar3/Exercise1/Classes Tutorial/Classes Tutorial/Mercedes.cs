using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    
  public class Mercedes : AbstractCar
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

        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }
        public string Description
        {
            get { return _description; }
            set { _description = value + "property Description"; }
        }

       public int Price
        {
            get { return _price; }
            set { _price = value + 50000; }
        }
    }
}
