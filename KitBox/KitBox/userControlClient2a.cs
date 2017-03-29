using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class userControlClient2a : UserControl
    {
        OrderManager om;

        public userControlClient2a(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void userControlClient2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlClient(om));
        }
    }
}
