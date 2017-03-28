using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class corniere : IElement
    {
        private string _code;
        private string _color;
        private int _height;
        private int _depth;
        private int _width;
        private bool _decoup;

        //Constructor
        public corniere(int height, int depth, int width, bool decoup)
        {
            _height = height;
            _depth = depth;
            _width = width;
            _decoup = decoup;
        }
        public void generateCode()
        {
            _code = "COR";
            _code += _height.ToString() + _color.ToString();

            if (_decoup)               
            {
                _code += "DEC";
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