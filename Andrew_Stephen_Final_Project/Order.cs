using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andrew_Stephen_Final_Project
{
    class Order
    {
        private const int _STARTING_ORDER = 1000;
        private const int _MAX_ORDER = 50;
        private int _orderNumber;
        private Food[] _foodArray;
        

        public Order()
        {
            _orderNumber = _STARTING_ORDER + frmMain.count;
            frmMain.count++;
            _foodArray = new Food[_MAX_ORDER];
        }

        public int OrderNumber
        {
            get { return _orderNumber; }
            set { _orderNumber = value; }
        }

        public Food[] FoodArray
        {
            get { return _foodArray; }
            set { _foodArray = value; }
        }
    }
}
