using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitbox
{
    class Casier
    {
        private int _height;
        private int _width;
        private int _depth;
        private string _color;
        private List<IElement> _elements;

        public Casier(int height, int width, int depth, string color, List<IElement> elements)
        {
            int _height = height;
            int _widht = width;
            int _depth = depth;
            string _color = color;
            List<IElement> _elements = elements;
        }
        // à implémenter
        public void chooseElement()
        {
        }
        public int comparePrice()
        {
            return 0;
        }
    }
}
