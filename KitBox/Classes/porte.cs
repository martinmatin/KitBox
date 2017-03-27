using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Porte : IElement
    {
        private string _code;
        private string _color;
        private int _height;
        private int _depth;
        private int _width;


        //Constructor
        public Porte(string color, int width, int height)
        {
            this._color = color;
            this._width = width;
            this._height = height;
        }

        public void generateCode()
        {
            string tmpCode = "";
            tmpCode += "POR";
            tmpCode += this._height.ToString();
            tmpCode += this._width.ToString();

            if(this._color.Contains("White"))
                tmpCode += "BL";
            else if (this._color.Contains("Brown"))
                tmpCode += "BR";
            else if (this._color.Contains("Aqua"))
                tmpCode += "VE";

            this._code = tmpCode;
        }
        private void colorCode()
        {

        }
        //Property Implementation
        public string code { get { return _code; } }
        public string color { get { return _color; } set { this._color = value; } }

        public int height { get { return _height; } set { this._height = value; } }
        public int depth { get { return _depth; } }
        public int width { get { return _width; } }


    }
}