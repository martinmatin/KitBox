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
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::KitBox.Properties.Resources.pg2_retour_btn1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 51);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnValidateClient
            // 
            this.btnValidateClient.BackColor = System.Drawing.Color.Transparent;
            this.btnValidateClient.BackgroundImage = global::KitBox.Properties.Resources.pg3_a_validerbutton;
            this.btnValidateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidateClient.FlatAppearance.BorderSize = 0;
            this.btnValidateClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnValidateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateClient.Location = new System.Drawing.Point(359, 482);
            this.btnValidateClient.Name = "btnValidateClient";
            this.btnValidateClient.Size = new System.Drawing.Size(397, 106);
            this.btnValidateClient.TabIndex = 4;
            this.btnValidateClient.UseVisualStyleBackColor = false;
            this.btnValidateClient.Click += new System.EventHandler(this.btnValidateClient_Click);
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifier.Location = new System.Drawing.Point(580, 229);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(354, 29);
            this.txtIdentifier.TabIndex = 5;
            this.txtIdentifier.Text = "test";            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(580, 313);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(354, 29);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "test";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(580, 399);
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.PasswordChar = '*';
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(354, 29);
            this.txtPasswordConfirmation.TabIndex = 7;
            this.txtPasswordConfirmation.Text = "test";
            // 
            // userControlClient2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KitBox.Properties.Resources.pg3_a_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.btnValidateClient);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "userControlClient2a";
            this.Size = new System.Drawing.Size(1091, 611);
            this.Load += new System.EventHandler(this.userControlClient2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnValidateClient;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordConfirmation;
    }
}
