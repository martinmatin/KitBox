namespace KitBox1._1
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
            this.btnIntro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntro
            // 
            this.btnIntro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIntro.BackColor = System.Drawing.Color.Transparent;
            this.btnIntro.BackgroundImage = global::KitBox1._1.Properties.Resources.home_button3;
            this.btnIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIntro.FlatAppearance.BorderSize = 0;
            this.btnIntro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIntro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntro.Font = new System.Drawing.Font("Open Sans", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.ForeColor = System.Drawing.Color.Transparent;
            this.btnIntro.Location = new System.Drawing.Point(587, 809);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(829, 175);
            this.btnIntro.TabIndex = 0;
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // userControlIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::KitBox1._1.Properties.Resources.home_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnIntro);
            this.DoubleBuffered = true;
            this.Name = "userControlIntro";
            this.Size = new System.Drawing.Size(2000, 1128);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntro;
    }
}
