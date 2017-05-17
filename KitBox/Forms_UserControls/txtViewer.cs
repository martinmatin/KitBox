using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KitBox
{
    public partial class txtViewer : Form
    {
        userControlCommandeP2 uc;
        userControlValidation ucV;
        userControlSearchCommand ucCC;


        string from, id;

        public userControlCommandeP2 userControlCommandeP2
        {
            get { return uc; }
            set { uc = value; }
        }

        public userControlValidation userControlValidation
        {
            get { return ucV; }
            set { ucV = value; }
        }

        public userControlSearchCommand userControlSearchCommand
        {
            get { return ucCC; }
            set { ucCC = value; }
        }

        public txtViewer(string from,string id)
        {
            InitializeComponent();
            this.from = from;
            this.id = id;
        }

        private void txtViewer_Load(object sender, EventArgs e)
        {
            ReadFile();
        }


        public void ReadFile()
        {
            TextReader reader;
            if(from.Equals("CommandeP2"))
            {
                reader = File.OpenText("missing.txt");
                txtBox.Text = reader.ReadToEnd();
                reader.Close();
            }
            else if (from.Equals("Validation_Magasinier"))
            {
                lblWhat.Text = "Résumé de la commande";
                reader = File.OpenText("valid_magasin_"+id+".txt");
                txtBox.Text = reader.ReadToEnd();
                reader.Close();
            }

            else if (from.Equals("Validation_Client"))
            {
                lblWhat.Text = "Résumé de la commande";
                reader = File.OpenText("valid_client_"+id+".txt");
                txtBox.Text = reader.ReadToEnd();
                reader.Close();
            }

        }


        private void txtViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //File.Delete(@"missing.txt");
        }
    }
}
