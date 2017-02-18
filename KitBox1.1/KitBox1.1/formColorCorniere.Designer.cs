namespace KitBox1._1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnBrown;
            System.Windows.Forms.Button btnBlack;
            this.btnWhite = new System.Windows.Forms.Button();
            btnBrown = new System.Windows.Forms.Button();
            btnBlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrown
            // 
            btnBrown.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            btnBrown.BackColor = System.Drawing.Color.SandyBrown;
            btnBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBrown.Location = new System.Drawing.Point(105, 40);
            btnBrown.Name = "btnBrown";
            btnBrown.Size = new System.Drawing.Size(50, 50);
            btnBrown.TabIndex = 1;
            btnBrown.UseVisualStyleBackColor = false;
            btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(24, 40);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(50, 50);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            btnBlack.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            btnBlack.BackColor = System.Drawing.Color.Black;
            btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBlack.Location = new System.Drawing.Point(187, 40);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new System.Drawing.Size(50, 50);
            btnBlack.TabIndex = 2;
            btnBlack.UseVisualStyleBackColor = false;
            btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // formColorCorniere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(276, 136);
            this.Controls.Add(btnBlack);
            this.Controls.Add(btnBrown);
            this.Controls.Add(this.btnWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formColorCorniere";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.Load += new System.EventHandler(this.formColorArmoire_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhite;
    }
}