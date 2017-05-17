using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Command
    {
        private Cabinet _cabinet;
        public string _date;
        public string _deliveryDate;

        public double _price;
        public bool _isPayed;
        public bool _isDelivered;
        public string _orderId;
        public string _clientId;

        public Command(){
            this._cabinet = new Cabinet();
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public double getPrice()
        {
            return _price;
        }
        public void setPrice(double price)
        {
            _price = price;
        }

        public void setDate(string date)
        {
            _date = date;
        }

        public Cabinet GetCabinet()
        {
            return this._cabinet;
        }  
    }
}
