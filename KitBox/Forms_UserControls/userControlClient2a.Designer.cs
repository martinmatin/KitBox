namespace KitBox
{
    partial class userControlClient2a
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnValidateClient = new System.Windows.Forms.Button();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::KitBox.Properties.Resources.pg2_retour_btn1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(13, 111);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 155);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValidateClient
            // 
            this.btnValidateClient.BackColor = System.Drawing.Color.Transparent;
            this.btnValidateClient.BackgroundImage = global::KitBox.Properties.Resources.pg3_a_validerbutton;
            this.btnValidateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidateClient.FlatAppearance.BorderSize = 0;
            this.btnValidateClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnValidateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateClient.Location = new System.Drawing.Point(680, 851);
            this.btnValidateClient.Margin = new System.Windows.Forms.Padding(6);
            this.btnValidateClient.Name = "btnValidateClient";
            this.btnValidateClient.Size = new System.Drawing.Size(686, 158);
            this.btnValidateClient.TabIndex = 4;
            this.btnValidateClient.UseVisualStyleBackColor = false;
            this.btnValidateClient.Click += new System.EventHandler(this.btnValidateClient_Click);
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifier.Location = new System.Drawing.Point(1160, 437);
            this.txtIdentifier.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(704, 51);
            this.txtIdentifier.TabIndex = 5;
            this.txtIdentifier.TextChanged += new System.EventHandler(this.txtIdentifier_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(1160, 602);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(704, 51);
            this.txtPassword.TabIndex = 6;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(924, 220);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(202, 79);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login";
            // 
            // userControlClient2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KitBox.Properties.Resources.pg3_a_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.btnValidateClient);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "userControlClient2a";
            this.Size = new System.Drawing.Size(2182, 1175);
            this.Load += new System.EventHandler(this.userControlClient2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValidateClient;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}
