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

        //Constructor
        public Panell(int height, int depth, int width, string orientation,string color)
        {
            _color = color;
            _height = height;
            _depth = depth;
            _width = width;
            _orientation = orientation;
        }

        public void GenerateCode()
        {
            _code = "";
            if (_orientation == "AR")
            { _code += "PAR" + _height + _width; }

            else if (_orientation == "GD")
            { _code += "PAG" + _height + _depth; }

            else if (_orientation == "HB")
            { _code += "PAH" + _depth + _width; }

            if (_color.Contains("White"))
                _code += "BL";
            else if (_color.Contains("Brown"))
                _code += "BR";
            else if (_color.Contains("Aqua"))
                _code += "VE";

        }
        //Propoerty Implementation
        public string Code { get { return _code; } }
        public string Color { get { return _color; } set { _color = value; } }

        public int Height { get { return _height; } set { _height = value; } }
        public int Depth { get { return _depth; } }
        public int Width { get { return _width; } }


    }
}