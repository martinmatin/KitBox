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
            _command = newCommand;
        }

        public void newClient(string name,string email, string id, string commandId)
        {
            Client cl = new Client(name, email, id, commandId);
            _client = cl;
        }
        public Client getClient()
        {
            return _client;
        }

        public Command getCommand()
        {
            return _command;
        }

        public void setCabinetDimensions(int width, int depth) {
            _command.GetCabinet().SetDimensions(width,depth);
        }
        public List<int> getCabinetDimensions()
        {
            return _command.GetCabinet().GetDimensions();
        }

        public void setCabinetColor(string color) {
            _command.GetCabinet().setColor(color);
        }

        public string getCabinetColor()
        {
            return _command.GetCabinet().getColor();
        }

        public void setAngleIronColor(string color) {
            _command.GetCabinet().setAngleIronColor(color);
        }

        public void NewUnit()
        {
            _command.GetCabinet().NewUnit();
        }

        public void setDoorColors(int index, string door, string color) {
            _command.GetCabinet().setUnitPartXColor(index, door, color );
        }

        public void setPanelColors(int index, string panel, string color)
        {
            _command.GetCabinet().setUnitPartXColor(index, panel, color);
        }

        public int getUnitHeight(int index)
        {
            return _command.GetCabinet().getUnitHeight(index);
        }

        public void setCasierHeight(int index, int height)
        {
            _command.GetCabinet().setCasierHeight(index, height);
        }

        public void ResetCabinet()
        {
            _command.GetCabinet().ResetCabinet();
        }
    }
}
