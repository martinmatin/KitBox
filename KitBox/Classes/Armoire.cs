using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Armoire
    {
        private List<Casier> _casiers;
        private int _width;
        private int _depth;
        private string _angleIronColor;
        private string _color;
        private bool canHaveDoors;

        public Armoire()
        {
            _casiers = new List<Casier>();
        }

        public bool getCanGetDoors()
        {
           return this.canHaveDoors;
        }

        public void setCanGetDoors(bool canHaveDoors)
        {
            this.canHaveDoors = canHaveDoors;
        }

        public Casier getCasier(int index)
        {
            return _casiers[index];
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
            Casier newCasier = new Casier(this._width, this._depth, this._color,this.canHaveDoors);
            _casiers.Add(newCasier);
        }

        //Remove Unit
        public void removeCasier(int index)
        {
            _casiers.RemoveAt(index);
        }

        public void duplicateCasier(int index)
        {
            _casiers.RemoveAt(_casiers.Count() - 1);
            _casiers.Add(_casiers[index]);
        }

        //Set CasierPartieX
        public void setCasierPartieXColor(int index, string door, string color)
        {
            _casiers[index].setColorPartieX(door, color);
        }

        //Get CasierHeight
        public int getCasierHeight(int index)
        {
            return _casiers[index].getHeight();
        }
        //Set CasierHeight
        public void setCasierHeight(int index, int height)
        {
            _casiers[index].setHeight(height);
        }


        //Reset Cabinet
        public void resetCabinet()
        {
            this._casiers = new List<Casier>();
        }

        //Generate Code
        public void generateCode()
        {
            foreach (var casier in _casiers)
            {
                casier.generateCode();
            }
        }

    }
}
