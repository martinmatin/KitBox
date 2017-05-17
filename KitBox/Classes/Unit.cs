using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Unit
    {
        private int _height;
        private int _width;
        private int _depth;
        private string _color = "White";
        private bool _canHaveDoors;
        private Dictionary<string, IElement> _elements;

        public Unit(int height, int width, int depth, string color, bool canHaveDoors)
        {
           _height = height;
            _width = width;
            _depth = depth;
            _canHaveDoors = canHaveDoors;
            //Set _color to white as default
            if (color.Contains("nocolor"))
                _color = "White";
            else
                _color = color;

            _elements = new Dictionary<string, IElement>();

            //Generating 2 Doors
            GenerateDoors();

            //Generating 5 Panels
            GeneratePanels();

            //Generating 4 Traverses
            GenerateRail();

            //Generating 4 Tassaux
            GenerateBracket(); 

        }

        public void GenerateDoors()
        {
            Door leftDoor, rightDoor;

            if (_canHaveDoors)
            {
                if ( _width.Equals(62))
                {
                    leftDoor = new Door( _color, ( _width / 2 + 1), _height);
                    rightDoor = new Door( _color, ( _width / 2 + 1), _height);
                }
                else
                {
                    leftDoor = new Door( _color, ( _width / 2 + 2), _height);
                    rightDoor = new Door( _color, ( _width / 2 + 2), _height);
                }

                _elements.Add("DL", leftDoor);
                _elements.Add("DR", rightDoor);
            }
        }

        public void GeneratePanels()
        {
            Panell PH  = new Panell( _height, _depth,  _width, "HB", _color);
            Panell PB  = new Panell( _height,  _depth,  _width, "HB",  _color);
            Panell PL  = new Panell( _height,  _depth,  _width, "GD",  _color);
            Panell PR  = new Panell( _height,  _depth,  _width, "GD",  _color);
            Panell PAR = new Panell( _height,  _depth,  _width, "AR",  _color);

            _elements.Add("PH", PH);
            _elements.Add("PB", PB);
            _elements.Add("PL", PL);
            _elements.Add("PR", PR);
            _elements.Add("PAR", PAR);
        }

        public void GenerateRail()
        {
            Traverse TAV = new Traverse(0, 0          ,  _width, "AV");
            Traverse TAR = new Traverse(0, 0          ,  _width, "AR");
            Traverse TG  = new Traverse(0,  _depth, 0          , "G" );
            Traverse TD  = new Traverse(0,  _depth, 0          , "D" );

            _elements.Add("TAV", TAV);
            _elements.Add("TAR", TAR);
            _elements.Add("TG", TG);
            _elements.Add("TD", TD);
        }

        public void GenerateBracket()
        {
            tasseau T= new tasseau( _height);
            for (int i = 1; i < 5; i++) {
                _elements.Add("T"+i.ToString(), T);
            }
        }

        public Dictionary<string, IElement> GetElements()
        {
            return  _elements;
        }

        //Get-Set Height
        public int getHeight()
        {
            return  _height;
        }

        public void setHeight(int height)
        {
             _height = height;
            foreach (var pair in _elements)
            {
                pair.Value.Height=height;
            }
        }

        //Get Width
        public int getWidth()
        {
            return  _width;
        }

        //Get Depth
        public int getDepth()
        {
            return  _depth;
        }

        //Get-Set Color
        public string getColor()
        {
            return  _color;
        }

        public void SetColorPartX(string partie, string color)
        {
            _elements[partie].Color = color;
            int countVE = 0;
            Shell shell = new Shell();
            foreach (KeyValuePair<string, IElement> elem in _elements)
            {
                if ((elem.Key.Contains("DL")) || (elem.Key.Contains("DR"))){
                    if (elem.Value.Color.Contains("Aqua"))
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
                _elements.Add("COUPEL"+x.ToString(),shell);
            }     
        }

        public void GenerateCode()
        {
            foreach (var pair in _elements)
            {
                _elements[pair.Key].GenerateCode();
            }
        }       
    }
}
