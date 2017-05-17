using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class tasseau : IElement
    {
        private string _code;
        private string _color;
        private int _height;
        private int _depth;
        private int _width;

        //Constructor
        public tasseau(int height)
        {
            _height = height;
        }

        public void GenerateCode()
        {
            _code = "TAS" + (_height-5);
        }

        //Propoerty Implementation
        public string Code { get { return _code; } }
        public string Color { get { return _color; } set { _color = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Depth { get { return _depth; } }
        public int Width { get { return _width; } }
    }
}