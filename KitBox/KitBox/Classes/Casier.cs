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
        private string _color;
        private List<IElement> _elements;

        public Casier(int width, int depth)
        {
            int _widht = width;
            int _depth = depth;
        }

        //Get-Set Height
        public int getHeight()
        {
            return this._height;
        }

        public void setHeight(int height)
        {
            this._height = height;
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

        public void setColor(string color)
        {
            this._color = color;
        }



        public int comparePrice()
        {
            return 0;
        }

        public void addElement(IElement element)
        {
            _elements.Add(element);
        }

        public IElement getPG()
        {
            return _elements[0];
        }
        
    }
}
