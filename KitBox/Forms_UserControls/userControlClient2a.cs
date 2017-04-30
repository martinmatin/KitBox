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
        DatabaseManager dbm = new DatabaseManager();
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

        private void txtIdentifier_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValidateClient_Click(object sender, EventArgs e)
        {
            if (txtIdentifier.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dbm.login(txtIdentifier.Text,txtPassword.Text)=="")
            {
                MessageBox.Show("֍ ERROR ֎",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                om.newClient(txtIdentifier.Text, txtIdentifier.Text, dbm.login(txtIdentifier.Text, txtPassword.Text), "4");
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new userControlValidation(om));
            }
        }
    }
}
