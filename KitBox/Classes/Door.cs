using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Door : IElement
    {
        private string _code;
        private string _color;
        private int _height;
        private int _depth;
        private int _width;


        //Constructor
        public Door(string color, int width, int height)
        {
            _color = color;
            _width = width;
            _height = height;
        }

        public void GenerateCode()
        {
            string tmpCode = "";
            tmpCode += "POR";
            tmpCode += _height.ToString();
            tmpCode += _width.ToString();

            if(_color.Contains("White"))
                tmpCode += "BL";
            else if (_color.Contains("Brown"))
                tmpCode += "BR";
            else if (_color.Contains("Aqua"))
                tmpCode += "VE";

            _code = tmpCode;
        }
        private void colorCode()
        {

        }
        //Property Implementation
        public string Code { get { return _code; } }
        public string Color { get { return _color; } set { _color = value; } }

        public int Height { get { return _height; } set { _height = value; } }
        public int Depth { get { return _depth; } }
        public int Width { get { return _width; } }


    }
}