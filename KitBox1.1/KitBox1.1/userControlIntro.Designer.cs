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
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(494, 359);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(587, 139);
            this.btnIntro.TabIndex = 0;
            this.btnIntro.Text = "Construire une armoire";
            this.btnIntro.UseVisualStyleBackColor = true;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // userControlIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnIntro);
            this.Name = "userControlIntro";
            this.Size = new System.Drawing.Size(1594, 884);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIntro;
    }
}
