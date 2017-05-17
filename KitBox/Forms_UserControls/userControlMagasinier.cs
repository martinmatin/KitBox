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
    public partial class userControlMagasinier : UserControl
    {
        public userControlMagasinier()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlIntro());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlCommandeP1(null));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlSearchArticle());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlSearchCommand());
        }

        private void userControlMagasinier_Load(object sender, EventArgs e)
        {
            DatabaseManager dbm = new DatabaseManager();
            List<string> missing = dbm.VerifyStock();
            if (missing.Count() > 0)
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;
        }
    }
}
