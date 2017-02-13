using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox1._1
{
    public partial class userControlIntro : UserControl
    {
        public userControlIntro()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new userControlCommande());
        }
    }
}
