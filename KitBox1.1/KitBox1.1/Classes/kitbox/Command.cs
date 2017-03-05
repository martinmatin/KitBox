using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitbox
{
    class Command
    {
        private List<Armoire> _armoires;
        private DateTime _date;
        private double _price;

        public Command(List<Armoire> armoires,DateTime date, double price)
            {
            _armoires = armoires;
            _date = date;
            _price = price;
            }

       //à implétmenter
        public double calPrice()
        {
            return 0.00;
        }
        public void newCabinet()
        {
        }
    }
}
