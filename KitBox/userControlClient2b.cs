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

        public userControlClient2b(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void userControlClient2_Load(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtIdentifier.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Veuillez remplir toutes les cases.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (true /*can't login*/)
            {
                MessageBox.Show("L'identifiant et le mot de passe ne correspondent pas.",
                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*END*/
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlClient(om));
        }
    }
}
