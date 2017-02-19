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
    public partial class userControlCommande : UserControl
    {
        public userControlCommande()
        {
            InitializeComponent();
        }

        private void userControlCommande_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void formColor_Click(object sender, EventArgs e)
        {
            formColorArmoire f2 = new formColorArmoire();
            f2.userControlCommande = this; // Allow Form2 to access Form1 public members
            f2.ShowDialog();
        }

        private void corniereColor_Click(object sender, EventArgs e)
        {
            formColorCorniere f2 = new formColorCorniere();
            f2.userControlCommande = this; // Allow Form2 to access Form1 public members
            f2.ShowDialog();

        }

        public Color armCol
        {
            set
            {
                this.armoireCol.BackColor = value;
            }
        }

        public Color cornCol
        {
            set
            {
                this.corniereColor.BackColor = value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pictureHide.Visible = false;
            }
            else
            {
                pictureHide.Visible = true;

            }
        }
    }
}
