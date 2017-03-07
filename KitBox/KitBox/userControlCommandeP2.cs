using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace KitBox
{
    public partial class userControlCommandeP2 : UserControl
    {
        OrderManager om;
        int i = 1;
        int index = 0;
        public userControlCommandeP2(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void userControlCommandeP2_Load(object sender, EventArgs e)
        {
            om.newCasier();

            panelShelf7.Visible = false;
            btnGoToShelf7.Visible = false;

            panelShelf6.Visible = false;
            btnGoToShelf6.Visible = false;

            panelShelf5.Visible = false;
            btnGoToShelf5.Visible = false;

            panelShelf4.Visible = false;
            btnGoToShelf4.Visible = false;

            panelShelf3.Visible = false;
            btnGoToShelf3.Visible = false;

            panelShelf2.Visible = false;
            btnGoToShelf2.Visible = false;

            lblDepth.Text = om.getCabinetDimensions()[1].ToString() + " cm";
            lblWidth.Text = om.getCabinetDimensions()[0].ToString() + " cm";

        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            string temp = om.getCasierHeight(i-1).ToString();
            if (om.getCasierHeight(i-1).ToString().Equals("0"))
            {
                MessageBox.Show("Veuillez indiquer une hauteur pour votre dernier casier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                om.newCasier();
                index++;
                i++;
                Panel p = (Panel)this.Controls.Find(("panelShelf" + i.ToString()), true).FirstOrDefault();
                p.Visible = true;

                Button b = (Button)this.Controls.Find(("btnGoToShelf" + i.ToString()), true).FirstOrDefault();
                b.Visible = true;

                if (i < 7)
                {
                    btnAddShelf.Parent = p;
                    Type thisType = this.GetType();
                    MethodInfo theMethod = thisType.GetMethod("btnGoToShelf" + i.ToString() + "_Click");
                    EventArgs[] arr1 = new EventArgs[] { EventArgs.Empty, EventArgs.Empty };
                    theMethod.Invoke(this, arr1);
                }
                else if (i == 7)
                {
                    Type thisType = this.GetType();
                    MethodInfo theMethod = thisType.GetMethod("btnGoToShelf" + i.ToString() + "_Click");
                    EventArgs[] arr1 = new EventArgs[] { EventArgs.Empty, EventArgs.Empty };
                    theMethod.Invoke(this, arr1);
                }
                else
                {
                    btnAddShelf.Visible = false;
                }
            }
        }

        public void btnGoToShelf1_Click(object sender, EventArgs e)
        {
            index = 0;
            lblWhatShelf.Text = "Etage 1";
            changeCombo(index);
            unselectAll();
            btnGoToShelf1.BackgroundImage = Properties.Resources.color1;
        }

        public void btnGoToShelf2_Click(object sender, EventArgs e)
        {
            index = 1;
            lblWhatShelf.Text = "Etage 2";
            changeCombo(index);
            unselectAll();
            btnGoToShelf2.BackgroundImage = Properties.Resources.color2;
            //var value = Properties.Resources.ResourceManager.GetObject("grey3", Properties.Resources.Culture);
            //panelShelf1.BackgroundImage = (System.Drawing.Image)value;
        }

        public void btnGoToShelf3_Click(object sender, EventArgs e)
        {
            index = 2;
            lblWhatShelf.Text = "Etage 3";
            changeCombo(index);

            unselectAll();
            btnGoToShelf3.BackgroundImage = Properties.Resources.color3;

        }

        public void btnGoToShelf4_Click(object sender, EventArgs e)
        {
            index = 3;
            lblWhatShelf.Text = "Etage 4";
            changeCombo(index);

            unselectAll();
            btnGoToShelf4.BackgroundImage = Properties.Resources.color4;

        }

        public void btnGoToShelf5_Click(object sender, EventArgs e)
        {
            index = 4;
            lblWhatShelf.Text = "Etage 5";
            changeCombo(index);

            unselectAll();
            btnGoToShelf5.BackgroundImage = Properties.Resources.color5;

        }

        public void btnGoToShelf6_Click(object sender, EventArgs e)
        {
            index = 5;
            lblWhatShelf.Text = "Etage 6";
            changeCombo(index);

            unselectAll();
            btnGoToShelf6.BackgroundImage = Properties.Resources.color6;
        }

        public void btnGoToShelf7_Click(object sender, EventArgs e)
        {
            index = 6;
            lblWhatShelf.Text = "Etage 7";
            changeCombo(index);

            unselectAll();
            btnGoToShelf7.BackgroundImage = Properties.Resources.color7;
        }

        void changeCombo(int index)
        {
            comboPartie.SelectedValue = 1;
            comboPartie.SelectedText = "Portes";
            comboPartie.Text = "Portes";

            if (om.getCasierHeight(index).ToString().Equals("0"))
            {
                comboHauteur.SelectedValue = null;
                comboHauteur.SelectedText = null;
                comboHauteur.Text = null;
            }
            else
            {
                comboHauteur.SelectedValue = om.getCasierHeight(index).ToString() + "cm";
                comboHauteur.Text = om.getCasierHeight(index).ToString() + "cm";
            }
        }

        private void unselectAll()
        {
            btnGoToShelf1.BackgroundImage = Properties.Resources.grey1;
            btnGoToShelf2.BackgroundImage = Properties.Resources.grey2;
            btnGoToShelf3.BackgroundImage = Properties.Resources.grey3;
            btnGoToShelf4.BackgroundImage = Properties.Resources.grey4;
            btnGoToShelf5.BackgroundImage = Properties.Resources.grey5;
            btnGoToShelf6.BackgroundImage = Properties.Resources.grey6;
            btnGoToShelf7.BackgroundImage = Properties.Resources.grey7;

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            om.resetCabinet();
            this.Controls.Clear();
            this.Controls.Add(new userControlCommandeP1(om));
        }

        private void comboHauteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboHauteur.Text;
            if (!comboHauteur.Text.Equals(""))
            om.setCasierHeight(index, Convert.ToInt32(comboHauteur.Text.Replace("cm","")));

            int height = 0;
            for(int count = 0; count < i; count++)
            {
                height += om.getCasierHeight(count);
            }
            lblHeight.Text = height.ToString()+" cm";
        }

    }
}
