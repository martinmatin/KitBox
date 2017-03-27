namespace KitBox
{
    partial class userControlIntro
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGoToMagasinier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::KitBox.Properties.Resources.homme_button;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.Transparent;
            this.btnStart.Location = new System.Drawing.Point(722, 890);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(742, 144);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGoToMagasinier
            // 
            this.btnGoToMagasinier.BackgroundImage = global::KitBox.Properties.Resources.home_button_magasinier;
            this.btnGoToMagasinier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGoToMagasinier.FlatAppearance.BorderSize = 0;
            this.btnGoToMagasinier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoToMagasinier.Location = new System.Drawing.Point(10, 16);
            this.btnGoToMagasinier.Margin = new System.Windows.Forms.Padding(6);
            this.btnGoToMagasinier.Name = "btnGoToMagasinier";
            this.btnGoToMagasinier.Size = new System.Drawing.Size(286, 88);
            this.btnGoToMagasinier.TabIndex = 1;
            this.btnGoToMagasinier.UseVisualStyleBackColor = true;
            this.btnGoToMagasinier.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::KitBox.Properties.Resources.home_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnGoToMagasinier);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userControlIntro";
            this.Size = new System.Drawing.Size(2182, 1175);
            this.Load += new System.EventHandler(this.userControlIntro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGoToMagasinier;
    }
}
