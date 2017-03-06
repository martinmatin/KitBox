namespace KitBox
{
    partial class userControlCommandeP1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboProfondeur = new System.Windows.Forms.ComboBox();
            this.comboLargeur = new System.Windows.Forms.ComboBox();
            this.pictureHide = new System.Windows.Forms.PictureBox();
            this.checkUniformColor = new System.Windows.Forms.CheckBox();
            this.btnColorCorniere = new System.Windows.Forms.Button();
            this.btnColArmoire = new System.Windows.Forms.Button();
            this.btnGoToP2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            this.SuspendLayout();
            // 
            // comboProfondeur
            // 
            this.comboProfondeur.FormattingEnabled = true;
            this.comboProfondeur.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.comboProfondeur.Location = new System.Drawing.Point(1191, 350);
            this.comboProfondeur.Margin = new System.Windows.Forms.Padding(2);
            this.comboProfondeur.Name = "comboProfondeur";
            this.comboProfondeur.Size = new System.Drawing.Size(186, 28);
            this.comboProfondeur.TabIndex = 12;
            this.comboProfondeur.Text = "32";
            // 
            // comboLargeur
            // 
            this.comboLargeur.FormattingEnabled = true;
            this.comboLargeur.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.comboLargeur.Location = new System.Drawing.Point(1191, 283);
            this.comboLargeur.Margin = new System.Windows.Forms.Padding(2);
            this.comboLargeur.Name = "comboLargeur";
            this.comboLargeur.Size = new System.Drawing.Size(186, 28);
            this.comboLargeur.TabIndex = 11;
            this.comboLargeur.Text = "32";
            // 
            // pictureHide
            // 
            this.pictureHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pictureHide.Location = new System.Drawing.Point(947, 706);
            this.pictureHide.Margin = new System.Windows.Forms.Padding(0);
            this.pictureHide.Name = "pictureHide";
            this.pictureHide.Size = new System.Drawing.Size(430, 87);
            this.pictureHide.TabIndex = 19;
            this.pictureHide.TabStop = false;
            // 
            // checkUniformColor
            // 
            this.checkUniformColor.Location = new System.Drawing.Point(1336, 635);
            this.checkUniformColor.Margin = new System.Windows.Forms.Padding(2);
            this.checkUniformColor.Name = "checkUniformColor";
            this.checkUniformColor.Size = new System.Drawing.Size(33, 33);
            this.checkUniformColor.TabIndex = 18;
            this.checkUniformColor.UseVisualStyleBackColor = true;
            this.checkUniformColor.CheckedChanged += new System.EventHandler(this.checkUniformColor_CheckedChanged);
            // 
            // btnColorCorniere
            // 
            this.btnColorCorniere.BackColor = System.Drawing.Color.Maroon;
            this.btnColorCorniere.BackgroundImage = global::KitBox.Properties.Resources.changeColor;
            this.btnColorCorniere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorCorniere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorCorniere.Location = new System.Drawing.Point(1320, 530);
            this.btnColorCorniere.Margin = new System.Windows.Forms.Padding(2);
            this.btnColorCorniere.Name = "btnColorCorniere";
            this.btnColorCorniere.Size = new System.Drawing.Size(49, 50);
            this.btnColorCorniere.TabIndex = 17;
            this.btnColorCorniere.UseVisualStyleBackColor = false;
            this.btnColorCorniere.Click += new System.EventHandler(this.btnColorCorniere_Click);
            // 
            // btnColArmoire
            // 
            this.btnColArmoire.BackColor = System.Drawing.Color.SandyBrown;
            this.btnColArmoire.BackgroundImage = global::KitBox.Properties.Resources.changeColor;
            this.btnColArmoire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColArmoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColArmoire.Location = new System.Drawing.Point(1320, 723);
            this.btnColArmoire.Margin = new System.Windows.Forms.Padding(2);
            this.btnColArmoire.Name = "btnColArmoire";
            this.btnColArmoire.Size = new System.Drawing.Size(49, 50);
            this.btnColArmoire.TabIndex = 20;
            this.btnColArmoire.UseVisualStyleBackColor = false;
            this.btnColArmoire.Click += new System.EventHandler(this.btnColArmoire_Click);
            // 
            // btnGoToP2
            // 
            this.btnGoToP2.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToP2.BackgroundImage = global::KitBox.Properties.Resources.pg1_valider_bouton;
            this.btnGoToP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToP2.FlatAppearance.BorderSize = 0;
            this.btnGoToP2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoToP2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoToP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToP2.Location = new System.Drawing.Point(1177, 810);
            this.btnGoToP2.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoToP2.Name = "btnGoToP2";
            this.btnGoToP2.Size = new System.Drawing.Size(200, 77);
            this.btnGoToP2.TabIndex = 21;
            this.btnGoToP2.UseVisualStyleBackColor = false;
            this.btnGoToP2.Click += new System.EventHandler(this.btnGoToP2_Click);
            // 
            // userControlCommandeP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::KitBox.Properties.Resources.pg1_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnGoToP2);
            this.Controls.Add(this.pictureHide);
            this.Controls.Add(this.btnColArmoire);
            this.Controls.Add(this.checkUniformColor);
            this.Controls.Add(this.btnColorCorniere);
            this.Controls.Add(this.comboProfondeur);
            this.Controls.Add(this.comboLargeur);
            this.DoubleBuffered = true;
            this.Name = "userControlCommandeP1";
            this.Size = new System.Drawing.Size(1636, 940);
            this.Load += new System.EventHandler(this.userControlCommandeP1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProfondeur;
        private System.Windows.Forms.ComboBox comboLargeur;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.CheckBox checkUniformColor;
        public System.Windows.Forms.Button btnColorCorniere;
        public System.Windows.Forms.Button btnColArmoire;
        private System.Windows.Forms.Button btnGoToP2;
    }
}
