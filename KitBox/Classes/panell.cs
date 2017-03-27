using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Panell : IElement
    {
        private string _code;
        private string _color;
        private string _orientation;

        private int _height;
        private int _depth;
        private int _width;

        private int _position;


        //Constructor
        public Panell(int height, int depth, int width, string orientation,string color)
        {
            this._color = color;
            this._height = height;
            this._depth = depth;
            this._width = width;
            this._orientation = orientation;
        }

        public void generateCode()
        {
            _code = "";
            if (_orientation == "AR")
            { _code += "PAR" + _height + _width + _color; }

            else if (_orientation == "GD")
            { _code += "PAG" + _height + _depth + _color; }

            else if (_orientation == "HB")
            { _code += "PAH" + _depth + _width + _color; }


        }
        //Propoerty Implementation
        public string code { get { return _code; } }
        public string color { get { return _color; } set { this._color = value; } }

        public int height { get { return _height; } set { this._height = value; } }
        public int depth { get { return _depth; } }
        public int width { get { return _width; } }

        public int position { get { return _position; } }

    }
}