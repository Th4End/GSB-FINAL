namespace GSB_FINAL
{
    partial class FConnexion
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
            this.label1 = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.infoconnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "identifiant :";
            // 
            // identifiant
            // 
            this.identifiant.Location = new System.Drawing.Point(365, 160);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(115, 20);
            this.identifiant.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe : ";
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(365, 267);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(115, 20);
            this.mdp.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // infoconnection
            // 
            this.infoconnection.AutoSize = true;
            this.infoconnection.Location = new System.Drawing.Point(391, 396);
            this.infoconnection.Name = "infoconnection";
            this.infoconnection.Size = new System.Drawing.Size(0, 13);
            this.infoconnection.TabIndex = 5;
            // 
            // FConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 508);
            this.Controls.Add(this.infoconnection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.label1);
            this.Name = "FConnexion";
            this.Text = "FConnexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mdp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label infoconnection;
    }
}