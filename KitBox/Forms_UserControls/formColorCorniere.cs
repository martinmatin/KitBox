using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class formColorCorniere : Form
    {
        userControlCommandeP1 uc;
        public userControlCommandeP1 userControlCommandeP1
        {
            get { return uc; }
            set { uc = value; }
        }
        public formColorCorniere()
        {
            InitializeComponent();
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            uc.cornCol = Color.SandyBrown;
            this.Close();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            uc.cornCol = Color.White;
            this.Close();
        }

        private void formColorArmoire_Load(object sender, EventArgs e)
        {

        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            uc.cornCol = Color.Black;
            this.Close();
        }

        private void formColorCorniere_Load(object sender, EventArgs e)
        {

        }

        private void btnGalvanise_Click(object sender, EventArgs e)
        {
            uc.cornCol = Color.Gray;
            this.Close();
        }
    }
}
