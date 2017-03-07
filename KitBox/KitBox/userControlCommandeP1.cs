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
    public partial class userControlCommandeP1 : UserControl
    {
        OrderManager om = new OrderManager();
        public userControlCommandeP1(OrderManager om)
        {
            InitializeComponent();
            if (om == null)
                this.om.newOrder();
            else
                this.om = om;
                
        }

        private void btnColArmoire_Click(object sender, EventArgs e)
        {
            formColorArmoire f2 = new formColorArmoire();
            f2.userControlCommandeP1 = this; // Allow Form2 to access Form1 public members
            f2.ShowDialog();
        }

        private void btnColorCorniere_Click(object sender, EventArgs e)
        {
            formColorCorniere f2 = new formColorCorniere();
            f2.userControlCommandeP1 = this; // Allow Form2 to access Form1 public members
            f2.ShowDialog();
        }

        public Color armCol
        {
            set
            {
                this.btnColArmoire.BackColor = value;
            }
        }

        public Color cornCol
        {
            set
            {
                this.btnColorCorniere.BackColor = value;
            }
        }

        private void checkUniformColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUniformColor.Checked == true)
            {
                pictureHide.Visible = false;
            }
            else
            {
                pictureHide.Visible = true;

            }
        }

        private void btnGoToP2_Click(object sender, EventArgs e)
        {
            if (comboLargeur.Text.Equals("") || comboProfondeur.Text.Equals(""))
            {
                MessageBox.Show("Veuillez indiquer la profondeur et la largeur de votre armoire.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //sets amoire color
                if (checkUniformColor.Checked)
                    om.setCabinetColor(btnColArmoire.BackColor.ToString());
                else
                    om.setCabinetColor(null);

                //sets corniere color
                om.setAngleIronColor(btnColorCorniere.BackColor.ToString());

                //sets width and depth of cabinet
                om.setCabinetDimensions(Convert.ToInt32(comboLargeur.Text), Convert.ToInt32(comboProfondeur.Text));

                this.Controls.Clear();
                this.Controls.Add(new userControlCommandeP2(om));
            }
        }

        private void userControlCommandeP1_Load(object sender, EventArgs e)
        {
            if (om.getCabinetDimensions()[0].ToString().Equals("0"))
            {
                comboLargeur.Text = "";
                comboProfondeur.Text = "";
            }
            else
            {
                comboLargeur.Text = om.getCabinetDimensions()[0].ToString();
                comboProfondeur.Text = om.getCabinetDimensions()[1].ToString();
            }


        }
    }
}
