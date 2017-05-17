using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Cabinet
    {
        private List<Unit> _unit;
        private int _width;
        private int _depth;
        private string _angleIronColor;
        private string _color="nocolor";
        private bool _canHaveDoors;

        public Cabinet()
        {
            _unit = new List<Unit>();
        }

        //Get-Set Casiers
        public Unit GetUnit(int index)
        {
            return _unit[index];
        }

        public int UnitCount()
        {
            return _unit.Count();
        }

        //Get-Set Dimensions
        public List<int> GetDimensions()
        {
            return new List<int> { _width, _depth };
        }

        public void SetDimensions(int width, int depth)
        {
            _width = width;
            _depth = depth;
        }

        //Get-Set AngleIronColor
        public string GetAngleIronColor()
        {
            return _angleIronColor;
        }

        public void setAngleIronColor(string color)
        {
            _angleIronColor = color;
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
        public void NewUnit()
        {
            Unit NewUnit = new Unit(32,_width, _depth, _color, _canHaveDoors);
            _unit.Add(NewUnit);
        }

        //Remove Unit
        public void RemoveUnit(int index)
        {
            _unit.RemoveAt(index);
        }

        //Set Color of CasierPartieX
        public void setUnitPartXColor(int index, string door, string color)
        {
            _unit[index].SetColorPartX(door, color);
        }

        //Get CasierHeight
        public int getUnitHeight(int index)
        {
            return _unit[index].getHeight();
        }

        //Set CasierHeight
        public void setCasierHeight(int index, int height)
        {
            _unit[index].setHeight(height);
        }

        //Reset Cabinet
        public void ResetCabinet()
        {
           _unit = new List<Unit>();
        }

        //Generate Code
        public void GenerateCode()
        {
            foreach (var unit in _unit)
            {
                unit.GenerateCode();
            }
        }

        public Dictionary<string, int> getDicOfElements()
        {
            Dictionary<string, int> dicOfElements = new Dictionary<string, int>();
            for (int x = 0; x < _unit.Count  ; x++)
            {
                foreach (KeyValuePair<string, IElement> elem in _unit[x].GetElements())
                {
                    if (dicOfElements.ContainsKey(elem.Value.Code))
                    {
                        dicOfElements[elem.Value.Code]++;
                    }
                    else
                    {
                        dicOfElements.Add(elem.Value.Code, 1);
                    }
                }
            }
            AngleIron angleIron = new AngleIron(Convert.ToInt32(HeightAngleIron()[0]), _angleIronColor, HeightAngleIron()[1].Equals("DEC"));
            angleIron.GenerateCode();
            dicOfElements.Add(angleIron.Code, 4);

            return dicOfElements;
        }

        public string[] HeightAngleIron()
        {
            int[] size = new int[32] { 36, 46, 50, 56, 72, 75, 92, 100, 108, 112, 125, 138, 144, 150, 168, 175, 180, 184, 200, 216, 224, 225, 230, 250, 252, 275, 276, 280, 300, 325, 350, 375 };
            int height = 0;
            for (int count = 0; count < _unit.Count; count++)
            {
                height += getUnitHeight(count);
            }
            height = height + 4;
            if (size.Contains(height) == false)
            {
                foreach (int element in size)
                {
                    if (element >= height)
                    {
                        height = element;
                        break;
                    }
                }
            }
            string dec = "";
            if (height % 25 == 0)
            {
                dec = "DEC";
            }
            string angleIronHeight = height.ToString();
            string[] angleIronType = new string[2] { angleIronHeight, dec };
            return (angleIronType);
        }
    }
}
