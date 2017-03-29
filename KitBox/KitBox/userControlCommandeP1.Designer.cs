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
            this.lblNoDoors = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).BeginInit();
            this.SuspendLayout();
            // 
            // comboProfondeur
            // 
            this.comboProfondeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProfondeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProfondeur.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62"});
            this.comboProfondeur.Location = new System.Drawing.Point(1588, 428);
            this.comboProfondeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProfondeur.Name = "comboProfondeur";
            this.comboProfondeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboProfondeur.Size = new System.Drawing.Size(247, 59);
            this.comboProfondeur.TabIndex = 12;
            // 
            // comboLargeur
            // 
            this.comboLargeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLargeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLargeur.Items.AddRange(new object[] {
            "32",
            "42",
            "52",
            "62",
            "80",
            "100",
            "120"});
            this.comboLargeur.Location = new System.Drawing.Point(1588, 345);
            this.comboLargeur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboLargeur.Name = "comboLargeur";
            this.comboLargeur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboLargeur.Size = new System.Drawing.Size(247, 59);
            this.comboLargeur.TabIndex = 11;
            this.comboLargeur.SelectedIndexChanged += new System.EventHandler(this.comboLargeur_SelectedIndexChanged);
            // 
            // pictureHide
            // 
            this.pictureHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pictureHide.Location = new System.Drawing.Point(1263, 882);
            this.pictureHide.Margin = new System.Windows.Forms.Padding(0);
            this.pictureHide.Name = "pictureHide";
            this.pictureHide.Size = new System.Drawing.Size(573, 109);
            this.pictureHide.TabIndex = 19;
            this.pictureHide.TabStop = false;
            // 
            // checkUniformColor
            // 
            this.checkUniformColor.Location = new System.Drawing.Point(1781, 794);
            this.checkUniformColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkUniformColor.Name = "checkUniformColor";
            this.checkUniformColor.Size = new System.Drawing.Size(44, 41);
            this.checkUniformColor.TabIndex = 18;
            this.checkUniformColor.UseVisualStyleBackColor = true;
            this.checkUniformColor.CheckedChanged += new System.EventHandler(this.checkUniformColor_CheckedChanged);
            // 
            // btnColorCorniere
            // 
            this.btnColorCorniere.BackColor = System.Drawing.Color.SandyBrown;
            this.btnColorCorniere.BackgroundImage = global::KitBox.Properties.Resources.changeColor;
            this.btnColorCorniere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorCorniere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorCorniere.Location = new System.Drawing.Point(1760, 662);
            this.btnColorCorniere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColorCorniere.Name = "btnColorCorniere";
            this.btnColorCorniere.Size = new System.Drawing.Size(65, 62);
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
            this.btnColArmoire.Location = new System.Drawing.Point(1760, 904);
            this.btnColArmoire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColArmoire.Name = "btnColArmoire";
            this.btnColArmoire.Size = new System.Drawing.Size(65, 62);
            this.btnColArmoire.TabIndex = 20;
            this.btnColArmoire.UseVisualStyleBackColor = false;
            this.btnColArmoire.Click += new System.EventHandler(this.btnColArmoire_Click);
            // 
            // btnGoToP2
            // 
            this.btnGoToP2.BackColor = System.Drawing.Color.Transparent;
            this.btnGoToP2.BackgroundImage = global::KitBox.Properties.Resources.pg1_valider_button;
            this.btnGoToP2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToP2.FlatAppearance.BorderSize = 0;
            this.btnGoToP2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGoToP2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGoToP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToP2.Location = new System.Drawing.Point(1588, 1008);
            this.btnGoToP2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoToP2.Name = "btnGoToP2";
            this.btnGoToP2.Size = new System.Drawing.Size(267, 96);
            this.btnGoToP2.TabIndex = 21;
            this.btnGoToP2.UseVisualStyleBackColor = false;
            this.btnGoToP2.Click += new System.EventHandler(this.btnGoToP2_Click);
            // 
            // lblNoDoors
            // 
            this.lblNoDoors.AutoSize = true;
            this.lblNoDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDoors.ForeColor = System.Drawing.Color.White;
            this.lblNoDoors.Location = new System.Drawing.Point(83, 945);
            this.lblNoDoors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoDoors.Name = "lblNoDoors";
            this.lblNoDoors.Size = new System.Drawing.Size(1030, 51);
            this.lblNoDoors.TabIndex = 22;
            this.lblNoDoors.Text = "Attention : Pour cette lageur, il n\'y aura pas de portes";
            this.lblNoDoors.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::KitBox.Properties.Resources.pg2_retour_btn;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(24, 103);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(253, 100);
            this.btnBack.TabIndex = 23;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userControlCommandeP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::KitBox.Properties.Resources.pg1_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNoDoors);
            this.Controls.Add(this.btnGoToP2);
            this.Controls.Add(this.pictureHide);
            this.Controls.Add(this.btnColArmoire);
            this.Controls.Add(this.checkUniformColor);
            this.Controls.Add(this.btnColorCorniere);
            this.Controls.Add(this.comboProfondeur);
            this.Controls.Add(this.comboLargeur);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userControlCommandeP1";
            this.Size = new System.Drawing.Size(2181, 1175);
            this.Load += new System.EventHandler(this.userControlCommandeP1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboProfondeur;
        private System.Windows.Forms.ComboBox comboLargeur;
        private System.Windows.Forms.PictureBox pictureHide;
        private System.Windows.Forms.CheckBox checkUniformColor;
        public System.Windows.Forms.Button btnColorCorniere;
        public System.Windows.Forms.Button btnColArmoire;
        private System.Windows.Forms.Button btnGoToP2;
        private System.Windows.Forms.Label lblNoDoors;
        private System.Windows.Forms.Button btnBack;
    }
}
