using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Command
    {
        private Armoire _armoire;
        private DateTime _date;
        private double _price;

        public Command()
            {
            this._armoire = new Armoire();
            }

       //à implétmenter
        public double calPrice()
        {
            return 0.00;
        }

        public void newCabinet()
        {

        }

        public Armoire getArmoire()
        {
            return this._armoire;
        }
       
    }
}
