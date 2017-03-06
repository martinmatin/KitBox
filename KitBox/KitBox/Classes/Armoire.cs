using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Armoire
    {
        private List<Casier> _casiers;
        private int _width;
        private int _depth;
        private string _angleIronColor;
        private string _cabinetColor;

        public Armoire()
        {

        }


        //Get-Set Dimensions
        public List<int> getDimensions()
        {
            return new List<int> {_width,_depth};
        }

        public void setDimensions(int width, int depth)
        {
            this._width = width;
            this._depth = depth;
        }




        //Get-Set AngleIronColor
        public string getAngleIronColor()
        {
            return this._angleIronColor;
        }

        public void setAngleIronColor(string color)
        {
            this._angleIronColor = color;
        }


        //Get-Set CabinetColor
        public string getCabinetColor()
        {
            return this._cabinetColor;
        }

        public void setCabinetColor(string color)
        {
            this._cabinetColor = color;
        }


        //Add new Unit
        public void newUnit()
        {
            Casier newUnit = new Casier(this._width, this._depth);
            _casiers.Add(newUnit);
        }
    }
}
