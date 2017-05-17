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
            _height = height;
            _width = width;
            _depth = depth;
            _orientation = orientation;
        }

        public void GenerateCode()
        {
            _code = "TR";
            if (_depth != 0)
            {
                _code += "G" + _depth.ToString();
            }
            else if (_orientation == "AR")
            {
                _code += "R" + _width.ToString();
            }
            else if (_orientation == "AV")
            {
                _code += "F" + _width.ToString();
            }  
        }
        //Propoerty Implementation
        public string Code { get { return _code; } }
        public string Color { get { return _color; } set { _color = value; } }
        public int Height { get { return _height; } set { _height = value; } }
        public int Depth { get { return _depth; } }
        public int Width { get { return _width; } }


    }
}