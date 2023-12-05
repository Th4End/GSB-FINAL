namespace GSB_FINAL
{
    partial class modifmotdepasse
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifmotdepasse));
            this.dgvmodifmotdepasse = new System.Windows.Forms.DataGridView();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNouveau = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.Label();
            this.bsmodifmotdepasse = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodifmotdepasse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmodifmotdepasse)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmodifmotdepasse
            // 
            this.dgvmodifmotdepasse.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgvmodifmotdepasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmodifmotdepasse.Location = new System.Drawing.Point(113, 86);
            this.dgvmodifmotdepasse.Name = "dgvmodifmotdepasse";
            this.dgvmodifmotdepasse.Size = new System.Drawing.Size(555, 313);
            this.dgvmodifmotdepasse.TabIndex = 0;
            this.dgvmodifmotdepasse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(277, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNouveau
            // 
            this.txtNouveau.Location = new System.Drawing.Point(277, 241);
            this.txtNouveau.Name = "txtNouveau";
            this.txtNouveau.PasswordChar = '*';
            this.txtNouveau.Size = new System.Drawing.Size(211, 20);
            this.txtNouveau.TabIndex = 2;
            this.txtNouveau.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(277, 308);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(211, 20);
            this.txtConfirm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(274, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ancien Mot de passe ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(274, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "créer un mot de passe ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(274, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entrer de nouveau le mot de passe ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Enregistrer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.ForeColor = System.Drawing.Color.Red;
            this.txtInfo.Location = new System.Drawing.Point(245, 366);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(0, 13);
            this.txtInfo.TabIndex = 10;
            // 
            // modifmotdepasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtNouveau);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.dgvmodifmotdepasse);
            this.Name = "modifmotdepasse";
            this.Text = "modifmotdepasse";
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodifmotdepasse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsmodifmotdepasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsmodifmotdepasse;
        private System.Windows.Forms.DataGridView dgvmodifmotdepasse;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNouveau;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txtInfo;
    }
}