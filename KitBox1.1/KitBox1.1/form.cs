using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox1._1
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
            this.Controls.Clear();
            this.Controls.Add(new userControlIntro());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
