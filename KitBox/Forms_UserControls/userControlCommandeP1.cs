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
                //sets amoire _color
                if (checkUniformColor.Checked)
                    om.setCabinetColor(btnColArmoire.BackColor.ToString());
                else
                    om.setCabinetColor("nocolor");

                //sets AngleIron _color
                om.setAngleIronColor(btnColorCorniere.BackColor.ToString());

                //sets _width and _depth of cabinet
                om.setCabinetDimensions(Convert.ToInt32(comboLargeur.Text), Convert.ToInt32(comboProfondeur.Text));

                if (lblNoDoors.Visible == true)
                    om.getCommand().GetCabinet().setCanGetDoors(false);
                else
                    om.getCommand().GetCabinet().setCanGetDoors(true);

                this.BackgroundImage = null;
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

            if (om.getCabinetDimensions()[0].Equals(0))
                checkUniformColor.Checked = false;
            else if (om.getCabinetColor().Equals("nocolor"))
                checkUniformColor.Checked = false;
            else
                checkUniformColor.Checked = true;
        }

        private void comboLargeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboLargeur.SelectedIndex == 0) || (comboLargeur.SelectedIndex == 1) || (comboLargeur.SelectedIndex == 2) )
            {
                lblNoDoors.Visible = true;
            }
            else
                lblNoDoors.Visible = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlIntro());
        }
    }
}

