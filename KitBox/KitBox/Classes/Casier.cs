using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Casier
    {
        private int _height;
        private int _width;
        private int _depth;
        private string _color = "White";
        private bool canHaveDoors;
        private Dictionary<string, IElement> _elements;

        public Casier(int width, int depth, string color, bool canHaveDoors)
        {
            this._width = width;
            this._depth = depth;
            this.canHaveDoors = canHaveDoors;
            //Set color to white as default
            if (color.Contains("nocolor"))
                this._color = "White";
            else
                this._color = color;

            this._elements = new Dictionary<string, IElement>();

            //Generating 2 Doors
            generateDoors();

            //Generating 5 Panels
            generatePanels();

            //Generating 4 Traverses
            generateTraverses();
        }

        public void generateDoors()
        {
            Porte pg;
            Porte pd;
            if (canHaveDoors)
            {
                if (this._width.Equals(62))
                {
                    pg = new Porte(this._color, (this._width / 2 + 1),this._height);
                    pd = new Porte(this._color, (this._width / 2 + 1),this._height);
                }
                else
                {
                    pg = new Porte(this._color, (this._width / 2 + 2),this._height);
                    pd = new Porte(this._color, (this._width / 2 + 2),this._height);
                }

                _elements.Add("DL", pg);
                _elements.Add("DR", pd);
            }
        }

        public void generatePanels()
        {
            Panell PH  = new Panell(this._height,this._depth, this._width, "HB",this._color);
            Panell PB  = new Panell(this._height, this._depth, this._width, "HB", this._color);
            Panell PL  = new Panell(this._height, this._depth, this._width, "GD", this._color);
            Panell PR  = new Panell(this._height, this._depth, this._width, "GD", this._color);
            Panell PAR = new Panell(this._height, this._depth, this._width, "AR", this._color);

            _elements.Add("PH", PH);
            _elements.Add("PB", PB);
            _elements.Add("PL", PL);
            _elements.Add("PR", PR);
            _elements.Add("PAR", PAR);
        }

        public void generateTraverses()
        {
            Traverse TAV = new Traverse(0, 0          , this._width, "AV");
            Traverse TAR = new Traverse(0, 0          , this._width, "AR");
            Traverse TG  = new Traverse(0, this._depth, 0          , "G" );
            Traverse TD  = new Traverse(0, this._depth, 0          , "D" );


            _elements.Add("TAV", TAV);
            _elements.Add("TAR", TAR);
            _elements.Add("TG", TG);
            _elements.Add("TD", TD);

        }

        public IElement getElement(string key)
        {
            return this._elements[key];
        }

        public Dictionary<string, IElement> getElements()
        {
            return this._elements;
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
            int countVE = 0;
            coupelle coup = new coupelle();
            foreach (KeyValuePair<string, IElement> elem in _elements)
            {
                if ((elem.Key.Contains("DL")) || (elem.Key.Contains("DR"))){
                    if (elem.Value.color.Contains("Aqua"))
                    {
                        countVE++;
                    }
                }
            }
            if (_elements.ContainsKey("COUPEL1"))
            {
                _elements.Remove("COUPEL1");
            }
            if (_elements.ContainsKey("COUPEL2"))
            {
                _elements.Remove("COUPEL2");
            }
            for (int x = 1; x < countVE+1; x++)
            {
                _elements.Add("COUPEL"+x.ToString(),coup);
            }

          
        }

        public void generateCode()
        {
            foreach (var pair in _elements)
            {
                _elements[pair.Key].generateCode();
            }
        }

        public int comparePrice()
        {
            return 0;
        }


        
    }
}
