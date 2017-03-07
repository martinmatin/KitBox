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
        private string _color;

        public Armoire()
        {
            _casiers = new List<Casier>();
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
        public string getColor()
        {
            return this._color;
        }

        public void setColor(string color)
        {
            this._color = color;
        }


        //Add new Unit
        public void newCasier()
        {
            Casier newCasier = new Casier(this._width, this._depth, this._color);
            _casiers.Add(newCasier);
        }

        //Remove Unit
        public void removeCasier(int index)
        {
            _casiers.RemoveAt(index);
        }

        //Set CasierPartieX
        public void setCasierPartieXColor(int index, string partie, string color)
        {
            _casiers[index].setColorPartieX(partie, color);
        }

        //Set CasierHeight
        public void setCasierHeight(int index, int height)
        {
            _casiers[index].setHeight(height);
        }


        //Reset Cabinet
        public void resetCabinet()
        {
            this._casiers = null;
        }
    }
}
