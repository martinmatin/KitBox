namespace KitBox
{
    partial class formColorArmoire
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
            System.Windows.Forms.Button btnBrown;
            this.btnWhite = new System.Windows.Forms.Button();
            btnBrown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrown
            // 
            btnBrown.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            btnBrown.BackColor = System.Drawing.Color.SandyBrown;
            btnBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnBrown.Location = new System.Drawing.Point(101, 35);
            btnBrown.Margin = new System.Windows.Forms.Padding(2);
            btnBrown.Name = "btnBrown";
            btnBrown.Size = new System.Drawing.Size(41, 42);
            btnBrown.TabIndex = 3;
            btnBrown.UseVisualStyleBackColor = false;
            btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(35, 35);
            this.btnWhite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(41, 42);
            this.btnWhite.TabIndex = 2;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // formColorArmoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 113);
            this.Controls.Add(btnBrown);
            this.Controls.Add(this.btnWhite);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formColorArmoire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWhite;
    }
}