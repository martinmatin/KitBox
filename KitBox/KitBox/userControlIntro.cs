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

        }
    }
}
