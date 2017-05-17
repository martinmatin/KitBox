﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitBox
{
    public partial class FormMagasinierLogin : Form
    {
        userControlIntro ui;
        public userControlIntro userControlIntro
        {
            get { return ui; }
            set { ui = value; }
        }
        public FormMagasinierLogin()
        {
            InitializeComponent();
        }

        private void FormMagasinierLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("admin"))
            {
                ui.BackgroundImage = null;
                ui.Controls.Clear();
                ui.Controls.Add(new userControlMagasinier());
                this.Close();

            }
        }
    }
}
