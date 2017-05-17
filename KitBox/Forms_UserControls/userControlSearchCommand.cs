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
    public partial class userControlSearchCommand : UserControl
    {
        DatabaseManager dbm = new DatabaseManager();
        OrderManager om;
        public userControlSearchCommand()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControlSearchCommand_Load(null,null);
            String order_id = txtOrderId.Text;

            try
            {
                Dictionary<string, string> dicoCommandInfo = dbm.GetCommandInfo(Convert.ToInt32(order_id));
                Dictionary<string, string> dicoUserInfo = dbm.GetUserInfo(Convert.ToInt32(dicoCommandInfo["client_id"]));

                om.newClient(dicoUserInfo["name"], dicoUserInfo["email"], dicoUserInfo["client_id"], order_id);
                om.newOrder();
                om.getCommand()._clientId = dicoUserInfo["client_id"];
                om.getCommand()._orderId = order_id;

                om.getCommand()._date = dicoCommandInfo["order_date"];
                om.getCommand()._deliveryDate = dicoCommandInfo["delivery_date"];
                om.getCommand()._price = Convert.ToDouble(dicoCommandInfo["price"]);
                om.getCommand()._isDelivered = Convert.ToBoolean(dicoCommandInfo["isDelivered"]);
                om.getCommand()._isPayed = Convert.ToBoolean(dicoCommandInfo["isPayed"]);


                Dictionary<string, int> dicElements = dbm.FindPartsById(Convert.ToInt32(order_id));

                Dictionary<string, int> missingElements = dbm.ElementsInStock(dicElements)[1];
                Dictionary<string, int> dispElements = dbm.ElementsInStock(dicElements)[0];

                Dictionary<string, string> infos = checkInfos();


                btnDelivered.Visible = true;
                btnPayed.Visible = true;
                if (om.getCommand()._isDelivered)
                    btnDelivered.BackColor = Color.Green;
                else
                    btnDelivered.BackColor = Color.Red;

                if (om.getCommand()._isPayed)
                    btnPayed.BackColor = Color.Green;
                else
                    btnPayed.BackColor = Color.Red;
                /*
                editor edit = new editor();
                edit.PrintBill(infos, missingElements, dispElements);
                */
                txtViewer f2 = new txtViewer("Validation_Magasinier", infos["id"]);
                f2.userControlSearchCommand = this;
                f2.ShowDialog();
            }
            catch {
                MessageBox.Show("Pas de réservation sous ce numéro", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlMagasinier());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnPayed_Click(object sender, EventArgs e)
        {
            if (btnPayed.BackColor == Color.Red)
            {
                dbm.Pay(Convert.ToInt32(txtOrderId.Text));
                btnPayed.BackColor = Color.Green;
                editor edit = new editor();
                edit.PrintBill(checkInfos(), new Dictionary<string, int>(), dbm.FindPartsById(Convert.ToInt32(checkInfos()["id"])));
            }
            else
            {
                MessageBox.Show("Le client a déjà payé.", "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            if (btnDelivered.BackColor == Color.Red)
            {
                int result = dbm.Deliver(Convert.ToInt32(txtOrderId.Text));
                if (result == 1)
                    btnDelivered.BackColor = Color.Green;
                else
                {
                    MessageBox.Show("Certaines pièces ne sont pas encore arrivées.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void userControlSearchCommand_Load(object sender, EventArgs e)
        {
            om = new OrderManager();
            btnDelivered.Visible = false;
            btnPayed.Visible = false;
        }
    }
}
