using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitbox
{
    class OrderManager
    {
        private Client _client;
        private List<Command> _command;

        public OrderManager(Client client, List<Command> command)
        {
            _client = client;
            _command = command;
        }

        //Méthodes à implémenter
        public void newOrder() { }
        public void setDimensions(int width, int depth) { }
        public void setUnicolor(string color) { }
        public void setCabinetColor(string color) { }
        public void setAngleIronColor(string color) { }
        public void setHeight(int height) { }
        public void setDoorType(string type) { }
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
