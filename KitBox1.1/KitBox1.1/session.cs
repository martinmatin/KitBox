using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox1._1
{
    public class session
    {
        private client client;

        public session()
        {
            client = new client("julien");
        }
        public client getClient()
        {
            return this.client;
        }
    }
}
