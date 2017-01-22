﻿using System;
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

        public string StartEngine()
        {
            return "Engine started";
        }

        public string StartEngine(int milliseconds)
        {
            return "The car is starting in " + milliseconds + " milliseconds";
        }
        public int ShowRemainingNoOFKM(int noOfFuelLitres, int Consumption)
        {
           return noOfFuelLitres / Consumption * 100;
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
