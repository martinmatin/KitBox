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
    public partial class formColorArmoire : Form
    {
        userControlCommande uc;
        public userControlCommande userControlCommande
        {
            get { return uc; }
            set { uc = value; }
        }
        public formColorArmoire()
        {
            InitializeComponent();
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            uc.armCol = Color.SandyBrown;
            this.Close();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            uc.armCol = Color.White;
            this.Close();
        }

        private void formColorArmoire_Load(object sender, EventArgs e)
        {
          
        }
    }
}
