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
        string from;
        public userControlCommandeP2 userControlCommandeP2
        {
            get { return uc; }
            set { uc = value; }
        }

        public txtViewer(string from)
        {
            InitializeComponent();
            this.from = from;
        }

        private void txtViewer_Load(object sender, EventArgs e)
        {
            ReadFile();
        }


        public void ReadFile()
        {
            TextReader reader = File.OpenText("missing.txt");
            if(from.Equals("CommandeP2"))
            {
                reader = File.OpenText("missing.txt");
            }
            txtBox.Text = reader.ReadToEnd();
        }
    }
}
