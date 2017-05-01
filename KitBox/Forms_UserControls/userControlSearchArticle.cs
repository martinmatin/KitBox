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
    public partial class userControlSearchArticle : UserControl
    {

        DatabaseManager dm = new DatabaseManager();
        public userControlSearchArticle()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> detail = dm.stockDetail(textBox1.Text);

            if (detail.Count==0)
                return;

            textBox2.Text = textBox1.Text;
            textBox3.Text = detail[0];
            textBox4.Text = detail[1];
            textBox5.Text = detail[2];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlIntro());
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dm.modifyStock(textBox1.Text, "client_price", textBox3.Text);
            dm.modifyStock(textBox1.Text, "stock_q", textBox4.Text);
            dm.modifyStock(textBox1.Text, "minimal_q", textBox5.Text);
        }
    }
}