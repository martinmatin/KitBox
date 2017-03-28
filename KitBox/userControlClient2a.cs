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

        private void btnValidateClient_Click(object sender, EventArgs e)
        {
            if (txtIdentifier.Text.Equals("") || txtPassword.Text.Equals("") || txtPasswordConfirmation.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtPasswordConfirmation.Text)
            {
                MessageBox.Show("Les mots de passe ne corespondent pas.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (true /*e-mail déjà utilisé*/)
            {
                MessageBox.Show("Identiant déjà utilisé.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*END*/
            }
        }
    }
}
