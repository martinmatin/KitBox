using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    class Client
    {
        private string _name;
        private string _email;
        private string _client_id;
        private string _command_id;

        public Client(string name, string email, string client_id, string command_id)
        {
            _name = name;
            _email = email;
            _client_id = client_id;
            _command_id = command_id;
        }

        public void setName(string name) {
            _name = name;
        }
        //je ne comprends pas la fonction addClient
    }
}
