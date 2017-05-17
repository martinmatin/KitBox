namespace KitBox
{
    partial class formColorCorniere
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

        #region Windows Form Designer generated _code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the _code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnBlack;
            System.Windows.Forms.Button btnBrown;
            System.Windows.Forms.Button btnGalvanise;
            this.btnWhite = new System.Windows.Forms.Button();
            btnBlack = new System.Windows.Forms.Button();
            btnBrown = new System.Windows.Forms.Button();
            btnGalvanise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlack
            // 
            btnBlack.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            btnBlack.BackColor = System.Drawing.Color.Black;
            btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBlack.Location = new System.Drawing.Point(150, 37);
            btnBlack.Margin = new System.Windows.Forms.Padding(2);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new System.Drawing.Size(41, 42);
            btnBlack.TabIndex = 5;
            btnBlack.UseVisualStyleBackColor = false;
            btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnBrown
            // 
            btnBrown.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            btnBrown.BackColor = System.Drawing.Color.SandyBrown;
            btnBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBrown.Location = new System.Drawing.Point(83, 37);
            btnBrown.Margin = new System.Windows.Forms.Padding(2);
            btnBrown.Name = "btnBrown";
            btnBrown.Size = new System.Drawing.Size(41, 42);
            btnBrown.TabIndex = 4;
            btnBrown.UseVisualStyleBackColor = false;
            btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(17, 37);
            this.btnWhite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(41, 42);
            this.btnWhite.TabIndex = 3;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnGalvanise
            // 
            btnGalvanise.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            btnGalvanise.BackColor = System.Drawing.Color.DarkGray;
            btnGalvanise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGalvanise.Location = new System.Drawing.Point(217, 37);
            btnGalvanise.Margin = new System.Windows.Forms.Padding(2);
            btnGalvanise.Name = "btnGalvanise";
            btnGalvanise.Size = new System.Drawing.Size(41, 42);
            btnGalvanise.TabIndex = 6;
            btnGalvanise.UseVisualStyleBackColor = false;
            btnGalvanise.Click += new System.EventHandler(this.btnGalvanise_Click);
            // 
            // formColorCorniere
            // 
            this.ClientSize = new System.Drawing.Size(278, 113);
            this.Controls.Add(btnGalvanise);
            this.Controls.Add(btnBlack);
            this.Controls.Add(btnBrown);
            this.Controls.Add(this.btnWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formColorCorniere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.Load += new System.EventHandler(this.formColorCorniere_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhite;
    }
}