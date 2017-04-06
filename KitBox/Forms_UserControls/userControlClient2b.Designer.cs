namespace KitBox
{
    partial class userControlClient2b
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
            this.btnValidateClient = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValidateClient
            // 
            this.btnValidateClient.BackColor = System.Drawing.Color.Transparent;
            this.btnValidateClient.BackgroundImage = global::KitBox.Properties.Resources.pg3_a_validerbutton;
            this.btnValidateClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValidateClient.FlatAppearance.BorderSize = 0;
            this.btnValidateClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnValidateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidateClient.Location = new System.Drawing.Point(698, 893);
            this.btnValidateClient.Margin = new System.Windows.Forms.Padding(6);
            this.btnValidateClient.Name = "btnValidateClient";
            this.btnValidateClient.Size = new System.Drawing.Size(794, 204);
            this.btnValidateClient.TabIndex = 5;
            this.btnValidateClient.UseVisualStyleBackColor = false;
            this.btnValidateClient.Click += new System.EventHandler(this.btnValidateClient_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(1155, 541);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(704, 51);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "test";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentifier.Location = new System.Drawing.Point(1155, 409);
            this.txtIdentifier.Margin = new System.Windows.Forms.Padding(6);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(704, 51);
            this.txtIdentifier.TabIndex = 7;
            this.txtIdentifier.Text = "test";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(1155, 768);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(6);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(704, 51);
            this.txtConfirm.TabIndex = 9;
            this.txtConfirm.Text = "test";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1155, 654);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(704, 51);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "test";
            // 
            // userControlClient2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KitBox.Properties.Resources.pg3_a_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIdentifier);
            this.Controls.Add(this.btnValidateClient);
            this.DoubleBuffered = true;
            this.Name = "userControlClient2b";
            this.Size = new System.Drawing.Size(2182, 1175);
            this.Load += new System.EventHandler(this.userControlClient2b_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidateClient;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtName;
    }
}
