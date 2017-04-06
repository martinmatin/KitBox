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
        public userControlValidation(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dicOfElements = getDicOfElements();
            Dictionary<string, int> missingElements = dbm.ElementsInStock(dicOfElements)[1];
            Dictionary<string, int> dispElements = dbm.ElementsInStock(dicOfElements)[0];
            Dictionary<string, string> infos = checkInfos();

            editor edit = new editor();
            edit.printBill(infos,missingElements,dispElements);

            txtViewer f2 = new txtViewer("Validation");
            f2.userControlValidation = this;
            f2.ShowDialog();
        }

        private Dictionary<string, int> getDicOfElements()
        {
            Dictionary<string, int> dicOfElements = new Dictionary<string, int>();
            int y = om.getCommand().getArmoire().casierCount();
            for (int x = 0; x < y-1; x++)
            {
                Casier casier = this.om.getCommand().getArmoire().getCasier(x);
                foreach (KeyValuePair<string, IElement> elem in casier.getElements())
                {
                    if (dicOfElements.ContainsKey(elem.Value.code))
                    {
                        dicOfElements[elem.Value.code]++;
                    }
                    else
                    {
                        dicOfElements.Add(elem.Value.code, 1);
                    }

                }
            }
            return dicOfElements;
        }

        private Dictionary<string, string> checkInfos()
        {
            Dictionary<string, string> infos = new Dictionary<string, string>();
            infos.Add("nom", om.getClient()._name);
            infos.Add("num", "123");
            infos.Add("date", "todayyy");
            infos.Add("prix", om.getCommand().calPrice().ToString());
            infos.Add("etat", "dispo dans 1 semaine");
            infos.Add("id", "007");


            return infos;
        }
    }
}
