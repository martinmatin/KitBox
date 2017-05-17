﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox
{
    public class Client
    {
        public string _name;
        public string _email;
        public string _client_id;
        public string _command_id;

        public Client(string name, string email, string clientId, string command_id)
        {
            _name = name;
            _email = email;
            _client_id = clientId;
            _command_id = command_id;
        }

        public void SetName(string name) {_name = name;}
    }
}
