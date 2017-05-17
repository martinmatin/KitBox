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
    public partial class userControlValidation : UserControl
    {
        OrderManager om;
        DatabaseManager dbm = new DatabaseManager();

        Dictionary<string, string> infos;



        public userControlValidation(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
            Dictionary<string, int> dicOfElements = getDicOfElements();
            Dictionary<string, int> missingElements = dbm.ElementsInStock(dicOfElements)[1];
            Dictionary<string, int> dispElements = dbm.ElementsInStock(dicOfElements)[0];
            infos = checkInfos();
            editor edit = new editor();
            //edit.PrintBill(infos, missingElements, dispElements);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtViewer f2 = new txtViewer("Validation_Magasinier",infos["id"]);
            f2.userControlValidation = this;
            f2.ShowDialog();
        }

        private Dictionary<string, int> getDicOfElements()
        {
            Dictionary<string, int> dicOfElements = new Dictionary<string, int>();
            int y = om.getCommand().GetCabinet().UnitCount();
            for (int x = 0; x < y; x++)
            {
                Unit unit = this.om.getCommand().GetCabinet().GetUnit(x);
                foreach (KeyValuePair<string, IElement> elem in unit.GetElements())
                {
                    if (dicOfElements.ContainsKey(elem.Value.Code))
                    {
                        dicOfElements[elem.Value.Code]++;
                    }
                    else
                    {
                        dicOfElements.Add(elem.Value.Code, 1);
                    }

                }
            }
            return dicOfElements;
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtViewer f2 = new txtViewer("Validation_Client",infos["id"]);
            f2.userControlValidation = this;
            f2.ShowDialog();
        }

        private void userControlValidation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlIntro());
        }
    }
}
