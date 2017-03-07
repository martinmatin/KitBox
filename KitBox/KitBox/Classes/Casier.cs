using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Casier
    {
        private int _height;
        private int _width;
        private int _depth;
        private string _color = "White";
        private Dictionary<string, IElement> _elements;

        public Casier(int width, int depth, string color)
        {
            this._width = width;
            this._depth = depth;
            this._color = color;
      
            this._elements = new Dictionary<string, IElement>();

        }

        //Get-Set Height
        public int getHeight()
        {
            return this._height;
        }

        public void setHeight(int height)
        {
            this._height = height;
            foreach (var pair in _elements)
            {
                pair.Value.height=height;
            }
        }

        //Get Width
        public int getWidth()
        {
            return this._width;
        }



        //Get Depth
        public int getDepth()
        {
            return this._depth;
        }


        //Get-Set Color
        public string getColor()
        {
            return this._color;
        }

        public void setColorPartieX(string partie, string color)
        {
            _elements[partie].color = color;
        }



        public int comparePrice()
        {
            return 0;
        }


        
    }
}
