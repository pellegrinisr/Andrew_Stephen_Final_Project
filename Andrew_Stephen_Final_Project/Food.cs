using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew_Stephen_Final_Project
{
    class Food
    {
        private int _quantity;
        private double _price;
        private string _name;

        public Food()
        {
            _quantity = 0;
            _price = 0;
        }

        public Food(string name, int quant, double price)
        {
            _name = name;
            _quantity = quant;
            _price = price;
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
