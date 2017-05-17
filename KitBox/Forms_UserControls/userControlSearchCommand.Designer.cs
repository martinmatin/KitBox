namespace KitBox
{
    partial class userControlSearchCommand
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
        /// le contenu de cette méthode avec l'éditeur de _code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.btnPayed = new System.Windows.Forms.Button();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1415, 396);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "Recherche";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::KitBox.Properties.Resources.pg2_retour_btn1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(6, 84);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(279, 94);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(919, 420);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(6);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(406, 50);
            this.txtOrderId.TabIndex = 14;
            // 
            // btnPayed
            // 
            this.btnPayed.BackColor = System.Drawing.Color.Red;
            this.btnPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayed.ForeColor = System.Drawing.Color.Black;
            this.btnPayed.Location = new System.Drawing.Point(691, 748);
            this.btnPayed.Margin = new System.Windows.Forms.Padding(6);
            this.btnPayed.Name = "btnPayed";
            this.btnPayed.Size = new System.Drawing.Size(275, 100);
            this.btnPayed.TabIndex = 15;
            this.btnPayed.Text = "Payé";
            this.btnPayed.UseVisualStyleBackColor = false;
            this.btnPayed.Click += new System.EventHandler(this.btnPayed_Click);
            // 
            // btnDelivered
            // 
            this.btnDelivered.BackColor = System.Drawing.Color.Red;
            this.btnDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivered.ForeColor = System.Drawing.Color.Black;
            this.btnDelivered.Location = new System.Drawing.Point(1007, 748);
            this.btnDelivered.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(275, 100);
            this.btnDelivered.TabIndex = 16;
            this.btnDelivered.Text = "Livré";
            this.btnDelivered.UseVisualStyleBackColor = false;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // userControlSearchCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KitBox.Properties.Resources.trouverunecommande_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnDelivered);
            this.Controls.Add(this.btnPayed);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "userControlSearchCommand";
            this.Size = new System.Drawing.Size(2000, 1128);
            this.Load += new System.EventHandler(this.userControlSearchCommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Button btnPayed;
        private System.Windows.Forms.Button btnDelivered;
    }
}