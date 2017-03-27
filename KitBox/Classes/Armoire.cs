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
        private bool _canHaveDoors;

        public Armoire()
        {
            _casiers = new List<Casier>();
        }

        //Get-Set _canHaveDoors
        public bool getCanGetDoors()
        {
           return _canHaveDoors;
        }

        public void setCanGetDoors(bool canHaveDoors)
        {
            _canHaveDoors = canHaveDoors;
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
            _width = width;
            _depth = depth;
        }




        //Get-Set AngleIronColor
        public string getAngleIronColor()
        {
            return _angleIronColor;
        }

        public void setAngleIronColor(string color)
        {
            _angleIronColor = color;
        }


        //Get-Set CabinetColor
        public string getColor()
        {
                return _color;
        }

        public void setColor(string color)
        {
            _color = color;
        }


        //Add new Unit
        public void newCasier()
        {
            Casier newCasier = new Casier(_width, _depth, _color, _canHaveDoors);
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
           _casiers = new List<Casier>();
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
