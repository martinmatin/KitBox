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
            string clientId = dbm.Register(txtName.Text, txtIdentifier.Text, txtPassword.Text);
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
            else if (clientId=="")
            {
                MessageBox.Show("Identiant déjà utilisé.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                om.newClient(txtName.Text, txtIdentifier.Text, clientId, "999");
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                string dateAfter = DateTime.Now.AddDays(7).ToString("dd-MM-yyyy");

                om.getCommand().setDate(date);
                om.getCommand()._clientId = clientId;

                Dictionary<string, int> dicOfElements = om.getCommand().GetCabinet().getDicOfElements();
                Dictionary<string, int> missingElements = dbm.ElementsInStock(dicOfElements)[1];
                if (missingElements.Count > 0)
                {
                    om.getCommand()._deliveryDate = dateAfter;
                    om.getCommand()._isDelivered = false;
                    //ajouter a virtual

                }
                else
                {
                    om.getCommand()._deliveryDate = date;
                    om.getCommand()._isDelivered = true;
                    //enlever a real
                }
                dbm.ModifyStock(om.getCommand()._isDelivered, dicOfElements);

                string command_id = dbm.CreateCommand(om.getCommand());
                om.getCommand()._orderId = command_id;
                dbm.CreateOrderedPart(dicOfElements, command_id);
                editor edit = new editor();
                edit.PrintBill(checkInfos(), missingElements, dbm.ElementsInStock(dicOfElements)[0]);
                this.BackgroundImage = null;
                this.Controls.Clear();
                this.Controls.Add(new userControlValidation(om));
            }
        }

        

        

        private void userControlClient2b_Load(object sender, EventArgs e)
        {

        }

        private Dictionary<string, string> checkInfos()
        {
            Dictionary<string, string> infos = new Dictionary<string, string>();
            infos.Add("nom", om.getClient()._name);
            infos.Add("num", om.getClient()._email);
            infos.Add("date", om.getCommand()._date);
            infos.Add("prix", om.getCommand()._price.ToString() + " €");
            infos.Add("etat", om.getCommand()._isDelivered.ToString());
            infos.Add("id", om.getCommand()._orderId);
            infos.Add("payed", om.getCommand()._isPayed.ToString());



            return infos;
        }
    }
}
