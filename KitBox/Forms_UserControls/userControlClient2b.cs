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
    public partial class userControlClient2b : UserControl
    {
        OrderManager om;
        DatabaseManager dbm = new DatabaseManager();
        public userControlClient2b( OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void btnValidateClient_Click(object sender, EventArgs e)
        {
            string client_id = dbm.register(txtName.Text, txtIdentifier.Text, txtPassword.Text);
            if (txtIdentifier.Text.Equals("") || txtPassword.Text.Equals("") || txtConfirm.Text.Equals("") || txtName.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Les mots de passe ne corespondent pas.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (client_id=="")
            {
                MessageBox.Show("Identiant déjà utilisé.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                om.newClient(txtName.Text, txtIdentifier.Text, client_id, "999");
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new userControlValidation(om));
            }
        }

        private void userControlClient2b_Load(object sender, EventArgs e)
        {

        }
    }
}
