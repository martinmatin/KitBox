using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Traverse : IElement
    {
        private string _code;
        private string _color;
        private string _orientation;
        private int _height;
        private int _depth;
        private int _width;


        //Constructor
        public Traverse(int height, int depth, int width, string orientation)
        {
            this._height = height;
            this._width = width;
            this._depth = depth;
            this._orientation = orientation;
        }

        public void generateCode()
        {
            _code = "TR";
            if (_depth != 0)
            {
                _code += "G" + _depth.ToString();
            }
            else if (_orientation == "Ar")
            {
                _code += "R" + _width.ToString();
            }
            else if (_orientation == "Av")
            {
                _code += "F" + _width.ToString();
            }
            
        }
        //Propoerty Implementation
        public string code { get { return _code; } }
        public string color { get { return _color; } set { this._color = value; } }

        public int height { get { return _height; } set { this._height = value; } }
        public int depth { get { return _depth; } }
        public int width { get { return _width; } }


    }
}