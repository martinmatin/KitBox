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
        private Command command;

        public OrderManager()
        {

        }

        //Méthodes à implémenter
        public void newOrder() {
            Command newCommand = new Command();
            this.command = newCommand;
        }

        public void setCabinetDimensions(int width, int depth) {
            this.command.getArmoire().setDimensions(width,depth);
        }
        public List<int> getCabinetDimensions()
        {
            return this.command.getArmoire().getDimensions();
        }

        public void setCabinetColor(string color) {
            this.command.getArmoire().setCabinetColor(color);
        }

        public void setAngleIronColor(string color) {
            this.command.getArmoire().setAngleIronColor(color);
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
