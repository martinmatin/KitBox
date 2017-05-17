using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Shell : IElement
    {
        private string _code;
        private string _color;

        private int _height;
        private int _depth;
        private int _width;


        //Constructor
        public Shell()
        {

        }

        public void GenerateCode()
        {
            this._code = "COUPEL";
        }

        //Propoerty Implementation
        public string Code { get { return _code; } }
        public string Color { get { return _color; } set { this._color = value; } }

        public int Height { get { return _height; } set { this._height = value; } }
        public int Depth { get { return _depth; } }
        public int Width { get { return _width; } }


    }
}