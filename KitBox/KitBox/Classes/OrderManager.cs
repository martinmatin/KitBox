using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class OrderManager
    {
        private Client _client;
        private Command _command;

        public OrderManager()
        {

        }

        //Méthodes à implémenter
        public void newOrder() {
            Command newCommand = new Command();
            this._command = newCommand;
        }

        public void setCabinetDimensions(int width, int depth) {
            this._command.getArmoire().setDimensions(width,depth);
        }
        public List<int> getCabinetDimensions()
        {
            return this._command.getArmoire().getDimensions();
        }

        public void setCabinetColor(string color) {
            this._command.getArmoire().setColor(color);
        }

        public void setAngleIronColor(string color) {
            this._command.getArmoire().setAngleIronColor(color);
        }

        public void newCasier()
        {
            this._command.getArmoire().newCasier();
        }

        public void setDoorColors(int index, string colorleft, string colorright) {
            this._command.getArmoire().setCasierPartieXColor(index, "PorteGauche", colorleft);
            this._command.getArmoire().setCasierPartieXColor(index, "PorteDroite", colorright);
        }
        
        public void setCasierHeight(int index, int height)
        {
            this._command.getArmoire().setCasierHeight(index, height);
        }


        public void setDoorType(string type) {
        }
        public void setDoorColors(string colorleft, string colorright) { }
        public void setPanelColorB(string color) { }
        public void setPanelColorL(string color) { }
        public void setPanelColorR(string color) { }
        public void setNewUnit(bool b) { }
        public void orderMultiplier(int num) { }
        public void identification(string id) { }
        public void pwdValidation(string pwd) { }
        public void registration(string email, string phontnumber, bool pwd, string name, string surname, string address) { }
    }


}
