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
        DatabaseManager dm = new DatabaseManager();
        public userControlSearchCommand()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) 

      

        {
            List<String> detail = dm.printOrder(textBox1.Text);
            int i;
            string infos = "";
            infos += "Nom du client" +"  :  "+ detail[0] + "\n";
            infos += "Contact du client" + "  :  " + detail[1] + "\n";
            infos += "Adresse" + "  :  " + detail[3] + "\n";
            infos += "ID de la commande" + "  :  " + detail[4] + "\n";
            infos += "Date de commande" + "  :  " + detail[5] + "\n";
            infos += "Date de livraison" + "  :  " + detail[6] + "\n";
            infos += "Prix total" + "  :  " + detail[7] + "\n";
            infos += "Prix payé" + "  :  " + detail[8] + "\n";
            infos += "Pièces commandées" + "  :  " + detail[10] + "\n";
            

            richTextBox1.Text = infos;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlIntro());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

