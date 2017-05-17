using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class AngleIron : IElement
    {
        private string _code;
        private string _color;
        private int _height;
        private int _depth;
        private int _width;
        private bool _cut;

        //Constructor
        public AngleIron(int height, string color, bool cut)
        {
            _height = height;
            _color = color;
            _cut = cut;
        }
        public void GenerateCode()
        {
            _code = "COR";
            _code += _height.ToString();
            if (_color.Contains("andy"))
            {
                _code += "BR";
            }
            else if (_color.Contains("White"))
            {
                _code += "BL";
            }
            else if (_color.Contains("Black"))
            {
                _code += "NR";
            }
            else if (_color.Contains("Gray"))
            {
                _code += "GL";
            }
            if (_cut)               
            {
                _code += "DEC";
            }
        }

        //Propoerty Implementation
        public string Code { get { return _code; } }
        public string Color { get { return _color; } set { this._color = value; } }

        public int Height { get { return _height; } set { this._height = value; } }
        public int Depth { get { return _depth; } }
        public int Width { get { return _width; } }
    }
}