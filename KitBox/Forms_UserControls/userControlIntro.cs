using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KitBox
{
    public partial class userControlIntro : UserControl
    {
        public userControlIntro()
        {
            InitializeComponent();
            btnStart.MouseEnter += new EventHandler(btnStart_HoverIn);
            btnStart.MouseLeave += new EventHandler(btnStart_HoverOut);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlCommandeP1(null));
        }

        private void btnStart_HoverIn(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = KitBox.Properties.Resources.homme_button_hover;
            Trace.TraceInformation("in");
        }

        private void btnStart_HoverOut(object sender, EventArgs e)
        {
            this.btnStart.BackgroundImage = KitBox.Properties.Resources.homme_button;
            Trace.TraceInformation("out");
        }

        private void userControlIntro_Load(object sender, EventArgs e)
        {
            
            DatabaseManager db_manager = new DatabaseManager();
            Dictionary<string, int> test = new Dictionary<string, int>();
            test = db_manager.FindPartsById(7);
            if (!db_manager.existTable())
            {
                db_manager.generateTable();

                string[] db_tables = new string[] { "stock", "part_info", "supplier_info" };
                foreach (string table in db_tables)
                {
                    db_manager.populateTable(table);
                }
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormMagasinierLogin f2 = new FormMagasinierLogin();
            f2.userControlIntro = this; // Allow Form2 to access Form1 public members
            f2.ShowDialog();
           
        }
    }
}
