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

        public void generateCode()
        {
            _code = "TAS" + _height;
        }

        //Propoerty Implementation
        public string code { get { return _code; } }
        public string color { get { return _color; } set { this._color = value; } }

        public int height { get { return _height; } set { this._height = value; } }
        public int depth { get { return _depth; } }
        public int width { get { return _width; } }


    }
}