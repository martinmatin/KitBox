using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitBox1._1
{
    public class client
    {
        private string name="";

        public client(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
