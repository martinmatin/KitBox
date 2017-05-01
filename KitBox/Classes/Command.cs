using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Command
    {
        private Armoire _armoire;
        private string _date;
        private double _price;
        private bool _isPayed;

        public Command(){
            this._armoire = new Armoire();
        }

       //à implétmenter
        public double calPrice()
        {
            return 0.00;
        }

        public void setDate(string datee)
        {
            _date = datee;
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
