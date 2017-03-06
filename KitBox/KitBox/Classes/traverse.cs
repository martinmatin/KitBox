using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Traverse : IElement
    {
        private string _reference;
        private string _code;
        private int _height;
        private int _depth;
        private int _width;
        private int _stock; //c'est plutot une variable de classe??
        private int _percase;
        private string _supplier;
        private double _clientprice;

        private int _position;

        //Constructor
        public Traverse(string reference, string code, int height, int depth, int width, int stock, int percase, string supplier, double clientprice, int position)
        {
            _reference = reference;
            _code = code;
            _height = height;
            _depth = depth;
            _width = width;
            _stock = stock;
            _percase = percase;
            _supplier = supplier;
            _clientprice = clientprice;

            _position = position;

        }
        //Propoerty Implementation
        public string code { get { return _code; } }
        public string reference { get { return _reference; } }
        public int height { get { return _height; } }
        public int depth { get { return _depth; } }
        public int width { get { return _width; } }
        public int stock { get { return _stock; } }
        public int percase { get { return _percase; } }
        public string supplier { get { return _supplier; } }
        public double clientprice { get { return _clientprice; } }

        public int position { get { return _position; } }

    }
}