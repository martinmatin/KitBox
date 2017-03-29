namespace KitBox
{
    partial class userControlClient
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSignup = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.Transparent;
            this.btnSignup.BackgroundImage = global::KitBox.Properties.Resources.pg3_button_1;
            this.btnSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Location = new System.Drawing.Point(291, 266);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(152, 96);
            this.btnSignup.TabIndex = 0;
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = global::KitBox.Properties.Resources.pg3_button_2;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(691, 266);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 96);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::KitBox.Properties.Resources.pg2_retour_btn1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KitBox.Properties.Resources.pg3_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSignup);
            this.DoubleBuffered = true;
            this.Name = "userControlClient";
            this.Size = new System.Drawing.Size(1091, 611);
            this.Load += new System.EventHandler(this.userControlClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
    }
}
